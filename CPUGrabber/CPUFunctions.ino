int Calibrate(){
  return 1;
}

void MapCoordinates(boolean cartesian){
  if(!cartesian){
    double x = double(xposNew);
    double y = double(yposNew);
    thetaNew = atan2(x,y)*57.2958;
    radiusNew = sqrt(pow(xposNew,2)+pow(yposNew,2));
    x = double(xpos);
    y = double(ypos);
    theta = atan2(x,y);
    radius = sqrt(pow(xpos,2)+pow(ypos,2));
  }
  else{
    xpos = radius * (cos(theta/(180.0/PI)));
    ypos = radius * (sin(theta/(180.0/PI)));

    if(DEBUG){
      Serial.print("Theta: ");Serial.println(theta, 2);
      Serial.print("Radius: ");Serial.println(radius, 2);
      Serial.print("Xpos: ");Serial.println(xpos, 2);
      Serial.print("Ypos: ");Serial.println(ypos, 2);
    }
  }

  if(DEBUG){
    Serial.println("Mapped coordinates: ");
    Serial.print("New theta: ");Serial.println(thetaNew,5);
    Serial.print("New radius: ");Serial.println(radiusNew, 2);
  }
  return;
}

void RelayCoordinates(){
  MapCoordinates(true);
  Serial.print("COOR: ");
  Serial.print(xpos);Serial.print(':');
  Serial.print(ypos);Serial.print(':');
  Serial.print(zpos);Serial.print(':');
  Serial.println(angle);
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
  
  if(DEBUG){
    Serial.println("Deltas are:");
    Serial.print("Theta: ");Serial.println(deltaTheta,2);
    Serial.print("Radius: ");Serial.println(deltaRadius,2);
    Serial.print("Z: ");Serial.println(deltaZ,2);
    Serial.print("Angle: ");Serial.println(deltaAngle,2);
  
  }
  
  //Do z chunk first if going up
  if(zposNew > zpos){

    if(DEBUG){
      Serial.println("Moving Up");
    }
    
    digitalWrite(Enable[ZMOTOR], LOW);
    for(int i=0;i<deltaZ;++i){
      for(int j=0;j<Z;++j){
        digitalWrite(Step[ZMOTOR], LOW);
        delay(3);
        digitalWrite(Step[ZMOTOR], HIGH);
        delay(1);
      }
      ++zpos;

      if(DEBUG){
        Serial.print("Z position: ");Serial.println(zpos);
      }
    }
    digitalWrite(Enable[ZMOTOR], HIGH);
  }

  if(DEBUG){
    Serial.println("Moving over");
  }

  boolean done = false;
  digitalWrite(Enable[RADMOTOR], LOW);
  digitalWrite(Enable[THETAMOTOR], LOW);
  while(!done){
    if(deltaTheta > .4){
      digitalWrite(Step[RADMOTOR], LOW);
      deltaTheta -= 1/float(THETA);
      theta += 1/float(THETA);
      if(DEBUG){
        Serial.print("Theta position: ");Serial.println(theta);
      }
    }
    if(deltaRadius > 0){
      digitalWrite(Step[THETAMOTOR], LOW);
      deltaRadius -= 1/float(RAD);
      radius += 1/float(RAD);
      if(DEBUG){
        Serial.print("Radius position: ");Serial.println(radius);
      }
    }
    if(deltaAngle > 0){
      digitalWrite(Step[ANGLEMOTOR], LOW);
      deltaAngle -= 1.8;
      angle += 1.8;
      if(DEBUG){
        Serial.print("Angle position: ");Serial.println(angle);
      }
    }
    delay(1);
    digitalWrite(Step[RADMOTOR], HIGH);
    digitalWrite(Step[THETAMOTOR], HIGH);
    digitalWrite(Step[ANGLEMOTOR], HIGH);
    delay(3);

    if(deltaTheta <= .4 && deltaRadius <= 0 && deltaAngle <= 0){
       done = true;
    }
  }

  if(zpos > zposNew){

    if(DEBUG){
      Serial.println("Moving down");
    }
    
    digitalWrite(Enable[ZMOTOR], LOW);
    for(int i=0;i<deltaZ;++i){
      for(int j=0;j<Z;++j){
        digitalWrite(Step[ZMOTOR], LOW);
        delay(3);
        digitalWrite(Step[ZMOTOR], HIGH);
        delay(1);
      }
      --zpos;

      if(DEBUG){
        Serial.print("Z position: ");Serial.println(zpos);
      }
    }
  }
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
      Serial.flush();
      if(DEBUG){
        Serial.println("Command received");
        Serial.println(inputString);
      }
      CommandProcess();
    } 
  }
}

void CommandProcess(){
  if(stringComplete){
    int i = 0;
    int len = inputString.length();
    char inputChars[50];
    for(i=0;i<=len;++i){
      inputChars[i]=inputString[i];
    }
    inputChars[i+1]='\n';
    char* command = strtok(inputChars, ":"); //break up input string
    char pieces[5][10];
    i = 0;
    
    while(command != NULL){ //iterate through sections
      if(i < 5){
        strcpy(pieces[i++], command);
        command = strtok(NULL, ":"); //This 
      }
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
      if(DEBUG){
        Serial.println("Command is SHIFT");
      }
      Shift = true;
    }
    else if(inputString.startsWith("MOVE")){ //Move to coordinates
      inputString = inputString.substring(5);
      if(DEBUG){
        Serial.println("Command is MOVE");
      }
    }
    else if(inputString.startsWith("REDEF")){ //Reorient coordinates
      inputString = inputString.substring(6);
      Redef = true;
      if(DEBUG){
        Serial.println("Command is REDEF");
      }
    }
    else if(inputString.startsWith("RELAY")){
      RelayCoordinates();
      inputString = "";
      stringComplete = false;
      return;
    }
    else{
      Serial.println("ERROR:NOVALIDCMD");
      inputString = "";
      stringComplete = false;
      return;
    }
    inputString = "";
    stringComplete = false;
    
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

    if(Redef){ //Still has issue
      xpos = xposNew;
      ypos = yposNew;
      zpos = zposNew;      
      angle = angleNew;
    }

    if(DEBUG){
      Serial.println("New Coordinates:");
      Serial.println(xposNew);
      Serial.println(yposNew);
      Serial.println(zposNew);
      Serial.println(angleNew);
      delay(100);
    }

    if(xposNew >= 0 && yposNew >= 0 && zposNew >= 0 && angleNew >=0 && xposNew < 1000 && yposNew < 1000 && zposNew < 1000 && angleNew < 360){
       Serial.println("NAVIGATING");
       MapCoordinates(false);
       Navigate();
       Serial.println("DONE");
       RelayCoordinates();
    }
    else{
      Serial.println("ERROR:EOB");
    }
  }
  else{
    Serial.println("ERROR");
    return;
  }
}
