int Calibrate(){
  return 1;
}

void MapCoordinates(boolean cartesian){
  if(!cartesian){
    thetaNew = atan(xposNew/yposNew);
    radiusNew = sqrt(pow(xposNew,2)+pow(yposNew,2));
    theta = atan(xpos/ypos);
    radius = sqrt(pow(xpos,2)+pow(ypos,2));
  }
  else{
    xpos = radius * cos(theta);
    ypos = radius * sin(theta);
  }
  return;
}

void Navigate(){ //Moves to new positions
  float deltaZ = 0;
  float deltaTheta = 0;
  float deltaRadius = 0;
  float deltaAngle = 0;
  
  if(radiusNew != radius){
    if(radiusNew > radius){
      digitalWrite(Dir[RADMOTOR], HIGH);
      deltaRadius =  radiusNew - radius;
    }
    else{
      digitalWrite(Dir[RADMOTOR], LOW);
      deltaRadius = radius - radiusNew;
    }
  }
  if(thetaNew != theta){
    if(thetaNew > theta){
      digitalWrite(Dir[THETAMOTOR], HIGH);
      deltaTheta = thetaNew - theta;
    }
    else{
      digitalWrite(Dir[THETAMOTOR], LOW);
      deltaTheta = theta - thetaNew;
    }
  }
  if(zposNew != zpos){
    if(zposNew > zpos){
      digitalWrite(Dir[ZMOTOR], HIGH);
      deltaZ = zposNew - zpos;
    }
    else{
      digitalWrite(Dir[ZMOTOR], LOW);
      deltaZ = zpos - zposNew;
    }
  }
  if(angleNew != angle){
    if(angleNew > angle){
      digitalWrite(Dir[ANGLEMOTOR], HIGH);
      deltaAngle = angleNew - angle;
    }
    else{
      digitalWrite(Dir[ANGLEMOTOR], LOW);
      deltaAngle = angle - angleNew;
    }
  }  
  //Do z chunk first if going up
  if(zposNew > zpos){
    digitalWrite(Enable[ZMOTOR], LOW);
    for(int i=0;i<deltaZ;++i){
      for(int j=0;j<Z;++j){
        digitalWrite(Step[ZMOTOR], LOW);
        delay(3);
        digitalWrite(Step[ZMOTOR], HIGH);
        delay(1);
      }
      ++zpos;
    }
  }
  
  boolean done = false;
  digitalWrite(Enable[RADMOTOR], LOW);
  digitalWrite(Enable[THETAMOTOR], LOW);
  while(!done){
    if(deltaTheta > 0){
      digitalWrite(Step[RADMOTOR], LOW);
      deltaTheta -= 1/THETA;
      theta += 1/THETA;
    }
    if(deltaRadius > 0){
      digitalWrite(Step[THETAMOTOR], LOW);
      deltaRadius -= 1/RAD;
      radius += 1/RAD;
    }
    if(deltaAngle > 0){
      digitalWrite(Step[ANGLEMOTOR], LOW);
      deltaAngle -= 1.8;
      angle += 1.8;
    }
    delay(1);
    digitalWrite(Step[RADMOTOR], HIGH);
    digitalWrite(Step[THETAMOTOR], HIGH);
    digitalWrite(Step[ANGLEMOTOR], HIGH);
    delay(3);

    if(deltaTheta <= 0 && deltaRadius <= 0 && deltaAngle <= 0){
       done = true;
    }
  }

  if(zpos > zposNew){
    digitalWrite(Enable[ZMOTOR], LOW);
    for(int i=0;i<deltaZ;++i){
      for(int j=0;j<Z;++j){
        digitalWrite(Step[ZMOTOR], LOW);
        delay(3);
        digitalWrite(Step[ZMOTOR], HIGH);
        delay(1);
      }
      --zpos;
    }
  }
  return;
}

void RelayCoordinates(){
  Serial.print("COOR: ");
  Serial.print(xpos);Serial.print(ypos);Serial.print(zpos);
  Serial.println(angle);
  return;
}

void EmergencyStop(){
  return;
}

void serialEvent() {
  while (Serial.available()) {
    char inChar = (char)Serial.read(); 
    inputString += inChar;
    if (inChar == '\n' || inChar == '\r') {
      stringComplete = true;
      CommandProcess();
    } 
  }
}

void CommandProcess(){
  if(stringComplete){

    int len = inputString.length();
    char inputChars[50];
    for(int i=0;i<len;++i){
      inputChars[i]=inputString[i];
    }
    char* command = strtok(inputChars, ':'); //break up input string

    char pieces[4][10];
    int i = 0;
    while(command){ //iterate through sections
      if(i < 5){
        strcpy(pieces[i++], command);
      }
      if(DEBUG)
        Serial.println(command);
    }
    
    if(inputString.startsWith("STOP")){ //Emergency Brake
      EmergencyStop();
      Serial.println("STOPPING");
      RelayCoordinates();
      return;
    }
    
    boolean Shift = false; //Shifting, not moving to coordinates
    boolean Redef = false;
    if(inputString.startsWith("SHIFT")){ //Move from where we are
      inputString = inputString.substring(6);
      Shift = true;
    }
    else if(inputString.startsWith("MOVE")){ //Move to coordinates
      inputString = inputString.substring(5);
    }
    else if(inputString.startsWith("REDEF")){ //Reorient coordinates
      inputString = inputString.substring(6);
      Redef = true;
    }
    
    xposNew = atoi(pieces[1]);
    yposNew = atoi(pieces[2]);
    zposNew = atoi(pieces[3]);
    angleNew = atof(pieces[4]);

    if(Shift){
      xposNew += xpos;
      yposNew += ypos;
      zposNew += zpos;      
      angleNew += angle;
    }

    if(Redef){
      xpos = xposNew;
      ypos = yposNew;
      zpos = zposNew;      
      angle = angleNew;
    }

    if(DEBUG){
      Serial.println(xposNew);
      Serial.println(yposNew);
      Serial.println(zposNew);
      Serial.println(angleNew);
    }

    if(xposNew >= 0 && yposNew >= 0 && zposNew >= 0 && angleNew >=0 && xposNew < 1000 && yposNew < 1000 && zposNew < 1000 && angleNew < 360){
       Serial.println("NAVIGATING");
       MapCoordinates(false);
       Navigate();
    }
    Serial.println("DONE");
    RelayCoordinates();
    inputString = "";
    stringComplete = false;
  }
  else{
    Serial.println("ERROR");
    return;
  }
}
