namespace D_GOOD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ISwitchable bulb = new LightBulb();
            Switch powerSwitch = new Switch(bulb);

            Console.WriteLine("Tryck på strömbrytaren:");
            Console.Write("Power Switch: ");
            powerSwitch.Toggle();
            Console.Write("Power Switch: ");
            powerSwitch.Toggle();
            Console.Write("Power Switch: ");
            powerSwitch.Toggle();

            ISwitchable spotLight = new SpotLight();
            Switch spotLightPowerSwitch = new Switch(spotLight);

            Console.Write("Power Switch: ");
            spotLightPowerSwitch.Toggle();
            Console.Write("Power Switch: ");
            spotLightPowerSwitch.Toggle();
            Console.Write("Power Switch: ");
            spotLightPowerSwitch.Toggle();
        }
    }
}