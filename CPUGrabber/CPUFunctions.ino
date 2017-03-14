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
  Serial.print(xpos);Serial.print(':');
  Serial.print(ypos);Serial.print(':');
  Serial.print(zpos);Serial.print(':');
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
    char* command = strtok(inputChars, ":"); //break up input string

    char pieces[5][10];
    int i = 0;
    while(command && i < 5){ //iterate through sections
      if(i < 5){
        strcpy(pieces[i++], command);
        command = strtok(NULL, ":");
      }
    }
    
    if(strcmp(pieces[0], "STOP") == 0){ //Emergency Brake
      if(DEBUG)
        Serial.println("Stop found");
      
      EmergencyStop();
      Serial.println("STOPPING");
      RelayCoordinates();
      return;
    }
    
    boolean Shift = false; //Shifting, not moving to coordinates
<<<<<<< HEAD
    boolean Redef = false;
    if(inputString.startsWith("SHIFT")){ //Move from where we are
      inputString = inputString.substring(6);
=======
    if(strcmp(pieces[0], "SHIFT") == 0){ //Move from where we are
      if(DEBUG)
        Serial.println("Shift found");
        
>>>>>>> 0a51f065de90851e1781c9502f1dac13f01d21ee
      Shift = true;
    }
    else if(strcmp(pieces[0], "MOVE") == 0){ //Move to coordinates
      if(DEBUG)
        Serial.println("Move found");
    }
<<<<<<< HEAD
    else if(inputString.startsWith("REDEF")){ //Reorient coordinates
      inputString = inputString.substring(6);
      Redef = true;
=======
    else if(strcmp(pieces[0], "REDEF") == 0){ //Reorient coordinates
      if(DEBUG)
        Serial.println("Redef found");
        
      xpos = atoi(pieces[1]);
      ypos = atoi(pieces[2]);
      zpos = atoi(pieces[3]);
      angle = atoi(pieces[4]);
      Serial.println("DONE");
      RelayCoordinates();
      inputString = "";
      stringComplete = false;
      return;
>>>>>>> 0a51f065de90851e1781c9502f1dac13f01d21ee
    }
    
    xposNew = atoi(pieces[1]);
    yposNew = atoi(pieces[2]);
    zposNew = atoi(pieces[3]);
    angleNew = atof(pieces[4]);

    if(DEBUG){
      Serial.print("X: ");Serial.println(xposNew);
      Serial.print("Y: ");Serial.println(yposNew);
      Serial.print("Z: ");Serial.println(zposNew);
      Serial.print("Angle: ");Serial.println(angleNew);
    }

    if(Shift){
      xposNew += xpos;
      yposNew += ypos;
      zposNew += zpos;      
      angleNew += angle;
    }

<<<<<<< HEAD
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

=======
>>>>>>> 0a51f065de90851e1781c9502f1dac13f01d21ee
    if(xposNew >= 0 && yposNew >= 0 && zposNew >= 0 && angleNew >=0 && xposNew < 1000 && yposNew < 1000 && zposNew < 1000 && angleNew < 360){
       Serial.println("NAVIGATING");
       MapCoordinates(false);
       Navigate();
    }

    else{
      Serial.println("ERROR:OOB");
    }
    Serial.println("DONE");
    RelayCoordinates();
    inputString = "";
    stringComplete = false;
  }
  else{
    Serial.println("ERROR:PARSE");
    return;
  }
}
