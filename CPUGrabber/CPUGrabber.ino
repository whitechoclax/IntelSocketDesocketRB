/*
   Main Program code for Intel CPU Grabber robot
   Arduino control portion, only works on MEGA
   The program receives commands and navigates
   using A4988 Stepper motor Drivers
*/

//Millimeter to step mappings
# define RAD 20
# define THETA 20 //to one degree
# define Z 20

//Motor Mappings
#define RADMOTOR 0
#define THETAMOTOR 1
#define ZMOTOR 2
#define ANGLEMOTOR 3

#define DEBUG 1

//Current position
int xpos = 0;
int ypos = 0;
int zpos = 0;
float angle = 0; //Angle for end effector

float theta = 0; //angle of robot
float radius = 0; //extension of arm

double thetaNew = 0;
int radiusNew = 0;

//Desired Positions
int xposNew = 0;
int yposNew = 0;
int zposNew = 0;
float angleNew = 0;

//Pin Mappings to Stepper Drivers based on shield
const byte Enable[6] = {A0, 8, A3, 2, A7, 26};
const byte Step[6] = {A1, 12, A5, 5, 50, 28};
const byte Dir[6] = {A2, 13, A6, 6, 52, 30};

String inputString = "";
//char str[] = "";


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
  }
  Serial.println("Booted1");
}

void loop() {
  delay(100);
}
