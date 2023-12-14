// create a light on command using ICommand interface

namespace CommandPattern
{
    public class LightOnCommand : ICommand
    {
        private Light light;

        public LightOnCommand(Light light)
        {
            this.light = light;
        }
        public void Execute()
        {
            light.On();
        }
    }
}

// create a fan on command using ICommand interface

namespace CommandPattern
{
    public class FanOnCommand : ICommand
    {
        private Fan fan;

        public FanOnCommand(Fan fan)
        {
            this.fan = fan;
        }
        public void Execute()
        {
            fan.On();
        }
    }
}