int Calibrate(){ //TBD Later
  return 1;
}

void MapCoordinates(){
  
  return;
}

void RelayCoordinates(){ //Send back coordinates
  MapCoordinates(); //Round them off, if need be 
  float zTmp = round(zpos);
  Serial.print("COOR:");
  Serial.print(traypos);Serial.print(':');
  Serial.println(zTmp);
  return;
}

void Navigate(){ //Moves to new positions
  int deltaZ = 0;
  traypos = trayposNew;
  
  if(zposNew != zpos){
    if(zposNew > zpos)
      deltaZ = zposNew - zpos;
    else
      deltaZ = zpos - zposNew;
  }
  if(trayposNew != traypos){
    if(trayposNew > traypos){
      digitalWrite(Dir[TRAYMOTOR], HIGH);
    }
    else{
      digitalWrite(Dir[TRAYMOTOR], LOW);
    }
  }  
  
  if(DEBUG){
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

  if(DEBUG){ //Move laterally
    Serial.println("Moving over");
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
        delay(3);
        digitalWrite(Step[ZMOTOR], HIGH);
        delay(1);
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
  return;
}

void serialEvent()
{ //Catch chars coming in
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
    
    zposNew = atoi(pieces[1]);//Assign actual values
    trayposNew = atoi(pieces[2]);
    
    if(Shift){
      zposNew += zpos;      
      trayposNew += traypos;
    }

    if(Redef){
      zpos = zposNew;      
      traypos = trayposNew;
    }

    if(DEBUG){
      Serial.println("New Coordinates:");
      Serial.println(zposNew);
      Serial.println(trayposNew);
      Serial.println("Old Coordinates:");
      Serial.println(traypos);
      Serial.println(zpos);
      delay(100);
    }

    if(trayposNew < 0 && trayposNew > -0.01){
      trayposNew = 0;
    }

    if(trayposNew >= 0 && zposNew >= 0 && trayposNew < 1000 && zposNew < 1000){
       Serial.println("NAVIGATING");
       MapCoordinates();
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
