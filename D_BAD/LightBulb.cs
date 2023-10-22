namespace D_BAD
{
    public class LightBulb
    {
        public bool LightOn { get; set; } = false;
        public void TurnOn()
        {
            Console.WriteLine("Ljuset är på.");
            LightOn = true;
        }

        public void TurnOff()
        {
            Console.WriteLine("Ljuset är av.");
            LightOn = false;
        }
    }
}
