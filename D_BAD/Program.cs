namespace D_BAD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Switch powerSwitch = new Switch();

            Console.Write("Power Switch: ");
            powerSwitch.Toggle();
            Console.Write("Power Switch: ");
            powerSwitch.Toggle();
            Console.Write("Power Switch: ");
            powerSwitch.Toggle();


        }
    }
}