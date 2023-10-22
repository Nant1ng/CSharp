namespace D_GOOD
{
    public class Switch
    {
        // Ingen dependency på LightBulb längre!
        private ISwitchable _device;

        public Switch(ISwitchable device)
        {
            _device = device; // Injicera beroendet
        }
        public void Toggle()
        {
            if (IsOn())
                _device.TurnOff();
            else
                _device.TurnOn();
        }
        public bool IsOn()
        {
            if (_device.LightOn)
                return true;
            return false;
        }
    }

}
