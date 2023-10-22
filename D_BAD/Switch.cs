namespace D_BAD
{
    public class Switch
    {
        private LightBulb bulb = new LightBulb();

        public void Toggle()
        {
            if (IsOn())
                bulb.TurnOff();
            else
                bulb.TurnOn();
        }
        public bool IsOn()
        {
            if (bulb.LightOn)
                return true;
            return false;
        }
    }

}
