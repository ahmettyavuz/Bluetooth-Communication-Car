#include <SoftwareSerial.h>

int solPin = 9;
int sagPin = 8;
int geriPin = 11;
int ileriPin = 10;
int e1 = 5;
int e2 = 6;


void setup() {
 
  pinMode(ileriPin, OUTPUT);
  pinMode(geriPin, OUTPUT);
  pinMode(sagPin, OUTPUT);
  pinMode(solPin, OUTPUT);
  Serial.begin(9600);
}


void loop() {
char veri=Serial.read();

switch(veri){
  case '1' : ileri1(); break;
  case '2' : ileri2(); break;
  case '3' : ileri3(); break;
  case 'b' : geri(); break;
  case 'r' : sag(); break;
  case 'l' : sol(); break;
  case 's' : dur(); break;
  case 'n' : duz(); break;
 
}

}


void ileri1(){
  analogWrite(e1 , 100); 
  digitalWrite(ileriPin, HIGH);
  digitalWrite(geriPin , LOW);

}

void ileri2(){
  analogWrite(e1 , 170); 
  digitalWrite(ileriPin, HIGH);
  digitalWrite(geriPin , LOW);

}

void ileri3(){
  analogWrite(e1 , 255); 
  digitalWrite(ileriPin, HIGH);
  digitalWrite(geriPin , LOW);

}

void geri(){
  analogWrite(e1 , 210);
  digitalWrite(ileriPin, LOW);
  digitalWrite(geriPin , HIGH);
}

void sag(){
  analogWrite(e2 , 210);
  digitalWrite(sagPin, HIGH);
  digitalWrite(solPin , LOW);
}

void sol(){
  analogWrite(e2 , 210);
  digitalWrite(sagPin, LOW);
  digitalWrite(solPin , HIGH);
}

void dur(){
  digitalWrite(ileriPin, LOW);
  digitalWrite(geriPin , LOW);
}

void duz(){
  digitalWrite(sagPin, LOW);
  digitalWrite(solPin , LOW);
}
