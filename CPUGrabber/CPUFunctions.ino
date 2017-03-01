int Calibrate(){
  return 1;
}

void Navigate(){
  
  return;
}

int MoveX(int distance, byte){
  return 1;
}

int MoveY(int distance){
  return 1;
}

int MoveZ(int distance){
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
    if(inputString.startsWith("STOP")){ //Emergency Brake
      EmergencyStop();
      Serial.println("STOPPING");
      RelayCoordinates();
      return;
    }
    
    if(inputString.startsWith("SHIFT ")){ //Move from where we are
      inputString = inputString.substring(6);
    }
    else if(inputString.startsWith("MOVE ")){ //Move to coordinates
      inputString = inputString.substring(5);
    }
    else if(inputString.startsWith("REDEF ")){ //Reorient coordinates
      inputString = inputString.substring(6);
    }
      
    xposNew = (inputString.substring(0, 2)).toInt();
    yposNew = (inputString.substring(3, 5)).toInt();
    zposNew = (inputString.substring(6, 8)).toInt();
    angleNew = (inputString.substring(9, 11)).toInt();

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
