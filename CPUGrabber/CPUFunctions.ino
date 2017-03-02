int Calibrate(){
  return 1;
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

      
    char* command = strtok(inputString, ':');
    while(command){
      
    }
    
    if(inputString.startsWith("STOP")){ //Emergency Brake
      EmergencyStop();
      Serial.println("STOPPING");
      RelayCoordinates();
      return;
    }
    
    boolean Shift = false;
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
    /*//Use split
    xposNew = (inputString.substring(0, 3)).toInt();
    yposNew = (inputString.substring(4, 7)).toInt();
    zposNew = (inputString.substring(8, 11)).toInt();
    angleNew = (inputString.substring(12, 15)).toInt();*/

    

    if(Shift){
      xposNew += xpos;
      yposNew += ypos;
      zposNew += zpos;      
      angleNew += angle;
    }

    if(DEBUG){
      Serial.println(xposNew);
      Serial.println(yposNew);
      Serial.println(zposNew);
      Serial.println(angleNew);
    }

    if(xposNew >= 0 && yposNew >= 0 && zposNew >= 0 && angleNew >=0 && xposNew < 1000 && yposNew < 1000 && zposNew < 1000 && angleNew < 1000){
       Serial.println("NAVIGATING");
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
