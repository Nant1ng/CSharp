namespace D_GOOD
{
    public interface ISwitchable
    {
        public bool LightOn { get; set; }
        void TurnOn();
        void TurnOff();
    }
}
