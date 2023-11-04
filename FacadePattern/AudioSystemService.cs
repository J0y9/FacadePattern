namespace FacadePattern;

public class AudioSystemService
{
    private Amplifier amplifier = new();
    private CdPlayer cdPlayer = new();
    private Speakers speakers = new();

    public void TurnOn()
    {
        amplifier.TurnOn();
        cdPlayer.Play();
        speakers.TurnOn();
    }

    public void TurnOff()
    {
        amplifier.TurnOff();
        cdPlayer.Stop();
        speakers.TurnOff();
    }

    public void SetVolume(int volume)
    {
        amplifier.SetVolume(volume);
    }
}