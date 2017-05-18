/*
   Main Program code for Intel CPU Grabber robot
   Arduino control portion, only works on MEGA
   The program receives commands and navigates
   using A4988 Stepper motor Drivers
*/

#include <Servo.h>
#include <EEPROMex.h>
Servo effector;

//Millimeter to step mappings
# define RAD 100
# define THETA 2 //to one degree
# define Z 100

//power settings: .5 A , 24v 
//Motor Mappings
#define RADMOTOR 0
#define THETAMOTOR 2
#define ZMOTOR 4
#define ANGLEMOTOR 6
#define RIGHT true
#define LEFT false
#define OUT true
#define IN false
//Grabber solenoid and Servo pins
#define GRABBER 29
#define SERVO 6
#define RADMEM 0
#define THETAMEM 4
#define ZMEM 8
#define ENDMEM 12

boolean DEBUG = false; 

//Current position
double xpos = 0;
double ypos = 150;
double zpos = EEPROM.readDouble(ZMEM);
double angle = EEPROM.readDouble(ENDMEM); //Angle for end effector

double theta = EEPROM.readDouble(THETAMEM); //angle of robot
double radius = EEPROM.readDouble(RADMEM); //extension of arm

double thetaNew = 0;
double radiusNew = 0;
double deltaZ = 0;
double deltaTheta = 0;
double deltaRadius = 0;
double deltaAngle = 0;

//Desired Positions
double xposNew = 0;
double yposNew = 0;
int zposNew = 0;
double angleNew = 0;

//Pin Mappings to Stepper Drivers based on shield
// z motor:   pins 2,5,6
//theta motor:  pins 8,12,13
const byte Enable[6] = {A0, 8, A3, 2, A7, 26};
const byte Step[6] = {A1, 12, A5, 5, 50, 28};
const byte Dir[6] = {A2, 13, A6, 6, 52, 30};

String inputString = "";
boolean CommandReceived = false;
boolean stringComplete = false;

void setup() {
  Serial.begin(115200);
  MapCoordinates(true);
  //Setup for pinouts
  for (int i = 0; i < 6; ++i) {
    pinMode(Enable[i], OUTPUT);
    digitalWrite(Enable[i], HIGH);
    pinMode(Step[i], OUTPUT);
    digitalWrite(Step[i], LOW);
    pinMode(Dir[i], OUTPUT);
    digitalWrite(Dir[i], LOW);
  }
  pinMode(31, OUTPUT);
  pinMode(33, OUTPUT);
  digitalWrite(31, HIGH);
  digitalWrite(33, LOW);
  pinMode(GRABBER, OUTPUT);
  digitalWrite(GRABBER, LOW);
  Serial.println("MAINROBOTARM");
  effector.attach(ANGLEMOTOR);
}

void loop() {
  delay(100);
}
