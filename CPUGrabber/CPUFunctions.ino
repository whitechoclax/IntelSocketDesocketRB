int Calibrate(){
  return 1;
}

void MapCoordinates(){
  return;
}

void Navigate(){ //Moves to new positions
  int deltaX = 0;
  int deltaY = 0;
  int deltaZ = 0;
  int deltaAngle = 0;
  
  if(xposNew != xpos){
    if(xposNew > xpos){
      digitalWrite(Dir[XMOTOR], HIGH);
      deltaX = xposNew - xpos;
    }
    else{
      digitalWrite(Dir[XMOTOR], LOW);
      deltaX = xpos - xposNew;
    }
  }
  if(yposNew != ypos){
    if(yposNew > ypos){
      digitalWrite(Dir[YMOTOR], HIGH);
      deltaY = yposNew - ypos;
    }
    else{
      digitalWrite(Dir[YMOTOR], LOW);
      deltaY = ypos - yposNew;
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

  int totalDelta = (deltaAngle + deltaZ + deltaY + deltaX);
  
  return;
}

int Move(int steps, int motor){
  //for(int i=0;i<steps
  return 1;
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
    if(strcmp(pieces[0], "SHIFT") == 0){ //Move from where we are
      if(DEBUG)
        Serial.println("Shift found");
        
      Shift = true;
    }
    else if(strcmp(pieces[0], "MOVE") == 0){ //Move to coordinates
      if(DEBUG)
        Serial.println("Move found");
    }
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
    }
    
    xposNew = atoi(pieces[1]);
    yposNew = atoi(pieces[2]);
    zposNew = atoi(pieces[3]);
    angleNew = atoi(pieces[4]);

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

    if(xposNew >= 0 && yposNew >= 0 && zposNew >= 0 && angleNew >=0 && xposNew < 1000 && yposNew < 1000 && zposNew < 1000 && angleNew < 360){
       Serial.println("NAVIGATING");
       MapCoordinates();
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
