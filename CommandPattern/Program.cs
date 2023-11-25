using Domain;
using Implementations;

SimpleRemoteControl remoteControl = new SimpleRemoteControl();

Light light = new Light();
LightOnCommand lightOn = new LightOnCommand(light);
LightOffCommand lightOff = new LightOffCommand(light);

remoteControl.SetOnCommand(0,lightOn);
remoteControl.SetOffCommand(0,lightOff);

remoteControl.OnButtonWasPressed(0);
remoteControl.OnButtonWasPressed(0);