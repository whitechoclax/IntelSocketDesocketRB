int Calibrate(){ //TBD Later
  return 1;
}

void CommandProcess(){//Parse command
  if(stringComplete){ //Tray position, z height
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
    boolean Redef = false;
    if(inputString.startsWith("MOVE")){ //Move to coordinates
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
      HOLDING = true;
      //Close servos
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
      HOLDING = false;
      //Open servos
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
      Serial.println("TRAYHANDLER");
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
    
    trayposNew = atoi(pieces[1]);//Assign actual values
    zposNew = atoi(pieces[2]);

    if(Redef){
      traypos = trayposNew;
      zpos = zposNew;
    }

    if(DEBUG){
      Serial.println("New Coordinates:");
      Serial.println(zposNew);
      Serial.println(trayposNew);
      Serial.println("Old Coordinates:");
      Serial.println(zpos);
      Serial.println(traypos);
      delay(100);
    }

    if(zposNew >= 0 && trayposNew >=0 && zposNew < 400 && trayposNew < 4){
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

void RelayCoordinates(){ //Send back coordinates
  float zTmp = round(zpos);
  EEPROM.updateDouble(ZMEM, zpos);
  EEPROM.updateDouble(TRAYMEM, traypos);
  if(DEBUG){
    Serial.println(EEPROM.readDouble(TRAYMEM));
    Serial.println(EEPROM.readDouble(ZMEM));
  }
  Serial.print("COOR:");
  Serial.print(traypos);Serial.print(':');
  Serial.println(zTmp);
  return;
}

void Navigate(){ //Moves to new positions
  float delayFactor = 0;
  int placesChange = abs(trayposNew - traypos);
  if(trayposNew != traypos){
    if(abs(trayposNew) > abs(traypos)){
      if(DEBUG){
        Serial.println("    Moving clockwise");
      }
      delayFactor = trayposNew/traypos;
      digitalWrite(Dir[TRAYMOTOR], HIGH);
    }
    else{
      if(DEBUG){
        Serial.println("    Moving counter-clockwise");
      }
      delayFactor = traypos/trayposNew;
      digitalWrite(Dir[TRAYMOTOR], LOW);
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
    Serial.print("traypos: ");Serial.println(placesChange,2);
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

      if(DEBUG){
        Serial.print("Z position: ");Serial.println(zpos);
      }
    }
    digitalWrite(Enable[ZMOTOR], HIGH);
  }

  boolean doneRad = false;
  boolean donetraypos = false;
  if(trayposNew == traypos){
    donetraypos = true;
    if(DEBUG){
      Serial.println("No tray change");
    }
  }
  
  int stepCount = 0;

  while(!donetraypos){
    serialEvent();
    //tray Section
    digitalWrite(Enable[TRAYMOTOR], LOW);
    digitalWrite(Step[TRAYMOTOR], LOW);
    delay(3);
    digitalWrite(Step[TRAYMOTOR], HIGH);
    if(DEBUG){
      Serial.print("Step count: ");Serial.println(90*placesChange - stepCount);
    }
    ++stepCount;
    delay(10);
    if(stepCount >= 90*placesChange){
      donetraypos = true;
      traypos = trayposNew;
      delay(1500);
      digitalWrite(Enable[TRAYMOTOR], HIGH);
    }  
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
      if(DEBUG){
        Serial.print("Z position: ");Serial.println(zpos);
      }
    }
    digitalWrite(Enable[ZMOTOR], HIGH);
  }
  return;
}

void EmergencyStop(){ //Resets movement information
  trayposNew = traypos;
  deltaZ = 0;
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
