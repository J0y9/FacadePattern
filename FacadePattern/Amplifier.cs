namespace FacadePattern;

public class Amplifier
{
    public void TurnOn()
    {
        Console.WriteLine("Amplifier is turned on.");
    }

    public void TurnOff()
    {
        Console.WriteLine("Amplifier is turned off.");
    }

    public void SetVolume(int volume)
    {
        Console.WriteLine($"Amplifier volume set to {volume}.");
    }
}