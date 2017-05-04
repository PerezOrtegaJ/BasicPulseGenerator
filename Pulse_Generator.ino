/* Pulse generator without delay
 *  
 *  
 */
const String psw = "jesus123";
const int pulseOut =  13;
     
int pulses=10, pulseTime=10, betweenTime=90;
float freq=10;
long interval = 1000;             

char inChar;
String inputString, commandStr, amountStr, checkStr;
   
boolean stringComplete = false; 
boolean accessRefused = true; 
boolean error=false;

void setup()
{
  Serial.begin(9600);
  Serial.println("Successful connection!");
  pinMode(pulseOut, OUTPUT);
}

void loop()
{
  if (stringComplete)
  {
    if(inputString=="send")
    {
      Serial.println("Sending...");
      //Serial.println("Sending: "+configString());
      for(int i=0;i<pulses;i++)
      {
        // Pulse ON
        digitalWrite(pulseOut, HIGH);
        delay(pulseTime);
        
        // Pulse OFF
        digitalWrite(pulseOut, LOW);
        delay(betweenTime);
      }
      Serial.println("Done!");
    }
    else if(inputString=="default")
    {
      pulses=10, pulseTime=10, betweenTime=90;
      freq=1.0/(pulseTime+betweenTime)*1000.0;
      //Serial.println("Configuration: "+configString());
    }
    else if(inputString=="check")
    {
      checkStr="check,";
      checkStr+=pulses;
      checkStr+=",";
      checkStr+=pulseTime;
      checkStr+=",";
      checkStr+=betweenTime;
      checkStr+=",";
      Serial.println(checkStr);
    }
    else
    {
      commandStr=inputString.substring(0,2);
      amountStr=inputString.substring(2,7);
      if(commandStr=="PP")
        pulses=amountStr.toInt();
      else if(commandStr=="PT")
        pulseTime=amountStr.toInt();
      else if(commandStr=="BT")
        betweenTime=amountStr.toInt();
      else
        error=true;
      if(error)
      {
       Serial.println("Wrong command!");
       error=false;
      }
      else
      {
       freq=1.0/(pulseTime+betweenTime)*1000.0;
       //Serial.println("Configuration: "+configString());
      }
    }
    
    stringComplete=false;
    inputString="";
  }
}

String configString()
{
  String configurationStr="";
  configurationStr+=pulses;
  configurationStr+=" pulses at ";
  configurationStr+=freq;
  configurationStr+=" Hz\n(pulse time: ";
  configurationStr+=pulseTime;
  configurationStr+=" ms; time between pulses: ";
  configurationStr+=betweenTime;
  configurationStr+=" ms)";
  return configurationStr;
}

void serialEvent()
{
  while (Serial.available())
  {
    inChar = (char)Serial.read();
    if (inChar == '\n')
      stringComplete = true;
    else
      inputString += inChar;
  }
}

