/*
   Main Program code for Intel CPU Grabber robot
   Arduino control portion, only works on MEGA
   The program receives commands and navigates
   using A4988 Stepper motor Drivers
*/

#include <Servo.h>
#include <EEPROMex.h>
Servo grabber1;
Servo grabber2;

//power settings: .5 A , 12v 
//Motor Mappings
#define Z 100
#define STEPS 180.0 * 5.18
#define TRAYMOTOR 2
#define ZMOTOR 4
#define RIGHT true
#define LEFT false
#define OUT true
#define IN false
#define TRAYMEM 4
#define ZMEM 0
#define SERVO1 3
#define SERVO2 4
#define HALLSENSOR A4

boolean DEBUG = false; 
boolean HOLDING = false;

//Current position
byte traypos = EEPROM.readDouble(TRAYMEM);
int zpos = EEPROM.readDouble(ZMEM);

//Desired Positions
byte trayposNew = 0;
int zposNew = 0;
double deltaZ = 0;

//Pin Mappings to Stepper Drivers based on shield
// z motor:   pins 2,5,6
//traypos motor:  pins 8,12,13
const byte Enable[6] = {A0, 8, A3, 2, A7, 26};
const byte Step[6] = {A1, 12, A5, 5, 50, 28};
const byte Dir[6] = {A2, 13, A6, 6, 52, 30};

String inputString = "";
boolean CommandReceived = false;
boolean stringComplete = false;

void setup() {
  Serial.begin(115200);

  //Setup for pinouts
  for (int i = 0; i < 6; ++i) {
    pinMode(Enable[i], OUTPUT);
    digitalWrite(Enable[i], HIGH);
    pinMode(Step[i], OUTPUT);
    digitalWrite(Step[i], LOW);
    pinMode(Dir[i], OUTPUT);
    digitalWrite(Dir[i], LOW);
  }
  pinMode(HALLSENSOR, INPUT);
  pinMode(SERVO1, OUTPUT);
  pinMode(SERVO2, OUTPUT);
  grabber1.attach(SERVO1);
  grabber2.attach(SERVO2);
  grabber1.write(20);
  grabber2.write(20);
  delay(250);
  Serial.println("TRAYHANDLER");
}

void loop() {
  delay(100);
}
