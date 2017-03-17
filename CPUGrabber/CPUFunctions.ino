int Calibrate(){
  return 1;
}

void MapCoordinates(boolean cartesian){
  if(!cartesian){
    double x = double(xposNew);
    double y = double(yposNew);
    Serial.println(xposNew);
    Serial.println(yposNew);
    thetaNew = atan(x/y)*57.2958;
    radiusNew = sqrt(pow(xposNew,2)+pow(yposNew,2));
    theta = atan(xpos/ypos);
    radius = sqrt(pow(xpos,2)+pow(ypos,2));
  }
  else{
    xpos = radius * cos(theta);
    ypos = radius * sin(theta);
  }
  if(DEBUG){
    Serial.println("Mapped coordinates: ");
    Serial.print("New theta: ");Serial.println(thetaNew,5);
    Serial.print("New radius: ");Serial.println(radiusNew);
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
  Serial.println("CommandProcess:");
  Serial.println(stringComplete);
  
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

    if(DEBUG){
      Serial.println("Command:");
      Serial.println(command);
      delay(1000);
    }
    
    while(command != NULL){ //iterate through sections
      if(i < 5){
        strcpy(pieces[i++], command);
        command = strtok(NULL, ":"); //This 
      }
      if(DEBUG){
        Serial.print("Current Piece is: (");
        Serial.print(i-1);
        Serial.print(") ");
        Serial.println(pieces[i-1]);
        delay(100);
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

    if(Redef){
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
       //Navigate();
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
