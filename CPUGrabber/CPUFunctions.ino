int Calibrate(){ //TBD Later
  return 1;
}

void CommandProcess(){//Parse command
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
        command = strtok(NULL, ":"); //This moves to next chunk
      }
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
    else if(inputString.startsWith("RELAY")){//Send coordinates
      RelayCoordinates();
      inputString = "";
      stringComplete = false;
      return;
    }
    else if(inputString.startsWith("GRAB")){//Send coordinates
      digitalWrite(GRABBER, HIGH);
      Serial.println("NAVIGATING");
      Serial.println("DONE");
      RelayCoordinates();
      if(DEBUG)
        Serial.println("Grabbing");
      inputString = "";
      stringComplete = false;
      return;
    }
    else if(inputString.startsWith("RELEASE")){//Send coordinates
      digitalWrite(GRABBER, LOW);
      Serial.println("NAVIGATING");
      Serial.println("DONE");
      RelayCoordinates();
      if(DEBUG)
        Serial.println("Releasing");
      inputString = "";
      stringComplete = false;
      return;
    }
    else if(inputString.startsWith("DEBUG")){//send debug messages
      if(DEBUG){
        DEBUG = false;
      }
      else{
        DEBUG = true;
        Serial.println("Debug on");
      }
      inputString = "";
      stringComplete = false;
      return;
    }
    else if(inputString.startsWith("QUERY")){//Send boot message
      Serial.println("MAINROBOTARM");
      inputString = "";
      stringComplete = false;
      return;
    }
    else{
      Serial.println("ERROR:NOVALIDCMD");//Command didn't make sense
      Serial.println(inputString); //what we received
      inputString = "";
      stringComplete = false;
      return;
    }
    inputString = "";
    stringComplete = false;
    
    xposNew = atoi(pieces[1]);//Assign actual values
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
      Serial.println("Old Coordinates:");
      Serial.println(xpos);
      Serial.println(ypos);
      Serial.println(zpos);
      Serial.println(angle);
      delay(100);
    }

    if(xposNew < 0 && xposNew > -0.01){
      xposNew = 0;
    }
    if(yposNew < 0 && yposNew > -0.01){
      yposNew = 0;
    }
    if(angleNew < 0 && angleNew > -0.01){
      angleNew = 0;
    }

    if(xposNew >= 0 && yposNew >= -600 && zposNew >= 0 && angleNew >=0 && xposNew < 600 && yposNew < 600 && zposNew < 600 && angleNew < 360){
       MapCoordinates(false);
       if(radiusNew < 159 || radiusNew > 490){
        Serial.println("ERROR:CRASH");
        return;
       }
       Serial.println("NAVIGATING");
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

void MapCoordinates(boolean cartesian){ //Converts cart -> cyl and back
  if(!cartesian){// If we call it with false, we convert cyl. coor.
    double x = double(xposNew);
    double y = double(yposNew);
    thetaNew = atan2(x,y)*57.2958;
    radiusNew = sqrt(pow(xposNew,2)+pow(yposNew,2));
    x = double(xpos);
    y = double(ypos);
    theta = abs(atan2(x,y)*57.2958);
    if(theta > 179.99){
      theta = 179.99;
    }
    if(theta < 0){
      theta = 0.01;
    }
    if(theta > 180){
      if(DEBUG){
        Serial.println("Theta calculation error");
      }
      thetaNew = theta;
      Serial.println("ERROR:EOB");
    }
    radius = sqrt(pow(xpos,2)+pow(ypos,2));
  }
  else{ //Convert to cart. coor
    xpos = radius * (sin(theta/(180.0/PI)));
    ypos = radius * (cos(theta/(180.0/PI)));
  }

  if(DEBUG){
    Serial.println("Mapped coordinates: ");
    Serial.print("Theta: ");Serial.println(theta, 4);
    Serial.print("Radius: ");Serial.println(radius, 2);
    Serial.print("New theta: ");Serial.println(thetaNew,4);
    Serial.print("New radius: ");Serial.println(radiusNew, 2);
  }
  return;
}

void RelayCoordinates(){ //Send back coordinates
  MapCoordinates(true); //Round them off, if need be 
  float xTmp = round(xpos); //round the real values if error
  float yTmp = round(ypos); //is an issue later
  float zTmp = round(zpos);
  EEPROM.updateDouble(THETAMEM, theta);
  EEPROM.updateDouble(RADMEM, radius);
  EEPROM.updateDouble(ZMEM, zpos);
  EEPROM.updateDouble(ENDMEM, angle);
  if(DEBUG){
    Serial.println(EEPROM.readDouble(THETAMEM));
    Serial.println(EEPROM.readDouble(RADMEM));
    Serial.println(EEPROM.readDouble(ZMEM));
    Serial.println(EEPROM.readDouble(ENDMEM));
  }
  Serial.print("COOR:");
  Serial.print(xTmp);Serial.print(':');
  Serial.print(yTmp);Serial.print(':');
  Serial.print(zTmp);Serial.print(':');
  Serial.print(angle,1);Serial.print(':');
  Serial.println(theta,2);
  return;
}

void Navigate(){ //Moves to new positions
  
  boolean radDirection;
  boolean thetaDirection;
  
  if(radiusNew != radius){ //These determine direction
    if(radiusNew > radius){
      digitalWrite(Dir[RADMOTOR], LOW);
      deltaRadius =  radiusNew - radius;
      radDirection = OUT;
    }
    else{
      digitalWrite(Dir[RADMOTOR], HIGH);
      deltaRadius = radius - radiusNew;
      radDirection = IN;
    }
  }
  float delayFactor = 0;
  if(thetaNew != theta){
    if(abs(thetaNew) > abs(theta)){
      if(DEBUG){
        Serial.println("    Moving clockwise");
      }
      delayFactor = thetaNew/theta;
      digitalWrite(Dir[THETAMOTOR], HIGH);
      deltaTheta = thetaNew - theta;
      thetaDirection = RIGHT;
    }
    else{
      if(DEBUG){
        Serial.println("    Moving counter-clockwise");
      }
      delayFactor = theta/thetaNew;
      digitalWrite(Dir[THETAMOTOR], LOW);
      deltaTheta = theta - thetaNew;
      thetaDirection = LEFT;
    }
  }
  if(zposNew != zpos){
    if(zposNew > zpos)
      deltaZ = zposNew - zpos;
    else
      deltaZ = zpos - zposNew;
  } 
  
  if(DEBUG){
    Serial.println("\nDeltas are:");
    Serial.print("Theta: ");Serial.println(deltaTheta,2);
    Serial.print("Radius: ");Serial.println(deltaRadius,2);
    Serial.print("Z: ");Serial.println(deltaZ,2);  
  }
  
  //Do z chunk first if going up
  if(zposNew > zpos){
    digitalWrite(Dir[ZMOTOR], HIGH);
    if(DEBUG){
      Serial.print("Moving Up: ");Serial.println(digitalRead(Dir[ZMOTOR]));
    }
    digitalWrite(Enable[ZMOTOR], LOW);
    for(int i=0;i<deltaZ;++i){
      for(int j=0;j<Z;++j){
        serialEvent();
        digitalWrite(Step[ZMOTOR], LOW);
        delayMicroseconds(500);
        digitalWrite(Step[ZMOTOR], HIGH);
        delayMicroseconds(500);
      }
      ++zpos;
    }
    digitalWrite(Enable[ZMOTOR], HIGH);
  }

  if(DEBUG){ //Move laterally
    Serial.println("Moving over");
  }

  boolean doneRad = false;
  boolean doneTheta = false;
  boolean doneAngle = false;

  int thetaOriginal = theta;
  int whereWereGoing = thetaOriginal + deltaTheta;
  int difference = whereWereGoing - theta;
  bool micro = false;
  if(difference < 9){
    micro = true;
  }
  if(DEBUG){
    Serial.print("Theta difference: ");Serial.println(abs(difference));
  }
  while(!doneTheta){
    serialEvent();
    if(deltaTheta > .4){  //Theta Section
      digitalWrite(Enable[THETAMOTOR], LOW);
      digitalWrite(Step[THETAMOTOR], LOW);
      delay(3);
      digitalWrite(Step[THETAMOTOR], HIGH);
      double x = ((theta-thetaOriginal)*2*PI)/(whereWereGoing - thetaOriginal);
      double tDelay = 5*cos(x)+5;
      int addDelay = (4*tDelay) + 15;
      if(!micro){
        if(DEBUG){
          Serial.print("addDelay: ");Serial.println(addDelay);
        }
        delay(addDelay);
      }
      else{
        delay(250);
      }
      deltaTheta -= 1/float(THETA);
      if(thetaDirection == LEFT){
        theta -= 1/float(THETA);
      }
      else
        theta += 1/float(THETA);
    }
    if(deltaTheta <= .4){
      doneTheta = true;
      delay(1500);
      digitalWrite(Enable[THETAMOTOR], HIGH);
    }  
  }
  while(!doneRad){  //Radius Section
    serialEvent();
    if(deltaRadius > 0.01){
      digitalWrite(Enable[RADMOTOR], LOW);
      digitalWrite(Step[RADMOTOR], LOW);
      delayMicroseconds(500);
      digitalWrite(Step[RADMOTOR], HIGH);
      delayMicroseconds(500);
      deltaRadius -= 1/float(RAD);
      if(radDirection == IN){
        radius -= 1/float(RAD);
      }
      else
        radius += 1/float(RAD);
      if(DEBUG){
        //Serial.print("Radius position: ");Serial.println(radius);
      }
    }
    if(deltaRadius <= 0.01){
      doneRad = true;
      digitalWrite(Enable[RADMOTOR], HIGH);
    }
  }
  
  effector.write(angleNew); //Angle Section
  angle = angleNew;
  if(DEBUG){
    Serial.print("Angle position: ");Serial.println(angle);
  }
  
  if(zpos > zposNew){ //Z going down, do last
    digitalWrite(Dir[ZMOTOR], LOW);
    if(DEBUG){
      Serial.print("Moving down: ");Serial.print(digitalRead(Dir[ZMOTOR]));
    }
    digitalWrite(Enable[ZMOTOR], LOW);
    for(int i=0;i<deltaZ;++i){
      for(int j=0;j<Z;++j){
        serialEvent();
        digitalWrite(Step[ZMOTOR], LOW);
        delayMicroseconds(500);
        digitalWrite(Step[ZMOTOR], HIGH);
        delayMicroseconds(500);
      }
      --zpos;
    }
    digitalWrite(Enable[ZMOTOR], HIGH);
  }
  return;
}

void EmergencyStop(){ //Resets movement information
  thetaNew = 0;
  radiusNew = 0;
  deltaZ = 0;
  deltaTheta = 0;
  deltaRadius = 0;
  return;
}

void serialEvent(){ //Catch chars coming in
  while (Serial.available()) 
  {
    while (Serial.available()){
      char inChar = (char)Serial.read();
      if (inChar >= 'A' && inChar <= 'Z' || inChar >= '0' && inChar <= ':' || inChar == '\r' || inChar == '-'){ 
        inputString += inChar;
        if (inChar == '\r'){
          stringComplete = true;
          Serial.flush();
          if(DEBUG){
            Serial.println("Command received");
            Serial.println(inputString);
          }
          if(inputString.startsWith("STOP")){ //Emergency Brake
            EmergencyStop();
            Serial.println("STOPPING");
            inputString = "";
            stringComplete = false;
            RelayCoordinates();
            return;
          }
          CommandProcess();
        } 
      }
    }
  }
}
