int message = 0;   //  This will hold one byte of the serial message
int LEDPin = 13;   //  This is the pin that the led is conected to
int LED = 0;      //  The value or brightness of the LED, can be 0-255


void setup() {  
  Serial.begin(9600);  //set serial to 9600 baud rate
    pinMode(LED_BUILTIN, OUTPUT);
}

void loop(){
    if (Serial.available() > 0) { //  Check to see if there is a new message
      message = Serial.read();    //  Put the serial input into the message

   if (message == 'A'){  //  If a capitol A is received
     //LED = 255;       //  Set LED to 255 (on)
     digitalWrite(LED_BUILTIN, HIGH);   // turn the LED on (HIGH is the voltage level)
     Serial.println("LED on");  // Send back LED on
   }
   if (message == 'a'){  //  If a lowercase a is received 
     //LED = 0;         //  Set LED to 0 (off)
     digitalWrite(LED_BUILTIN, LOW);    // turn the LED off by making the voltage LOW
     Serial.println("LED off");  // Send back LED off
   }
    }
}

