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
    while(command != NULL && i < 5){ //iterate through sections
      if(DEBUG){
        Serial.print("Current piece: ");Serial.println(command);
        delay(100);
      }
      if(i < 5){
        strcpy(pieces[i++], command);
        command = strtok(NULL, ":");
      }
    }
    
    if(inputString.startsWith("STOP")){ //Emergency Brake
      EmergencyStop();
      Serial.println("STOPPING");
      RelayCoordinates();
      return;
    }
    
    boolean Shift = false; //Shifting, not moving to coordinates
    if(inputString.startsWith("SHIFT")){ //Move from where we are
      inputString = inputString.substring(6);
      Shift = true;
    }
    else if(inputString.startsWith("MOVE")){ //Move to coordinates
      inputString = inputString.substring(5);
    }
    else if(inputString.startsWith("REDEF")){ //Reorient coordinates
      inputString = inputString.substring(6);
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
