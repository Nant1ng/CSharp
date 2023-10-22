namespace D_GOOD
{
    public class SpotLight : ISwitchable
    {
        public bool LightOn { get; set; } = false;
        public void TurnOn()
        {
            Console.WriteLine("Spotlight är på.");
            LightOn = true;
        }

        public void TurnOff()
        {
            Console.WriteLine("Spotlight är av.");
            LightOn = false;
        }
    }
}

