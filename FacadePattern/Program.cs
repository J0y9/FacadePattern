using FacadePattern;

// old way
// var amp = new Amplifier();
// var cdPlayer = new CdPlayer();
// var speakers = new Speakers();
// amp.TurnOn();
// cdPlayer.Play();
// speakers.TurnOn();

// Facade Pattern
var audioSystem = new AudioSystemService();
audioSystem.TurnOn();
audioSystem.SetVolume(12);
audioSystem.TurnOff();