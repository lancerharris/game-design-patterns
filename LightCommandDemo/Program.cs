using CommandPattern;

class Program
{
    static void Main(string[] args)
    {
        var light = new Light();
        var fan = new Fan();

        // create concrete commands
        var lightOn = new LightOnCommand(light);
        var fanOn = new FanOnCommand(fan);

        // create invoker
        var remote = new RemoteControl();

        // Turn on the light
        remote.SetCommand(lightOn);
        remote.PressButton();

        // Turn on the fan
        remote.SetCommand(fanOn);
        remote.PressButton();
    }
}
