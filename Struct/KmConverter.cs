namespace Struct
{
    public struct KmConverter
    {
        private float _km;
        private float _miles;

        public KmConverter(float km)
        {
            _km = km;
        }

        public float Km { get { return _km; } set { _km = value; } }

        public float Miles { get { return _miles; } set { _miles = value; } }

        public void ConvertedToMiles()
        {
            Miles = _km * 0.621371192f;
        }

        //public float ConvertedToMiles()
        //{
        //    float convertedValue = _km * 1.621371192f;

        //    return convertedValue;
        //}
    }
}
