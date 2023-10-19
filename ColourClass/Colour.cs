namespace ColourClass
{
    public class Colour
    {
        private int r;
        private int g;
        private int b;
        private int a;
        private int numberOfColours = 3;

        public Colour(int r, int g, int b, int a)
        {
            this.r = r;
            this.g = g;
            this.b = b;
            this.a = a;
        }

        public Colour(int r, int g, int b)
        {
            this.r = r;
            this.g = g;
            this.b = b;
            a = 255;
        }

        // public int shortcut { get; set; }

        //public int getR()
        //{
        //    return r;
        //}

        //public void setR(int r)
        //{
        //    this.r = r;
        //}

        public int R
        {
            get
            {
                return r;
            }
            set
            {
                r = value;
            }
        }

        public int getG()
        {
            return g;
        }

        public void setG(int g)
        {
            this.g = g;
        }

        public int getB()
        {
            return b;
        }

        public void setB(int b)
        {
            this.b = b;
        }

        public int getA()
        {
            return a;
        }

        public void setA(int a)
        {
            this.a = a;
        }

        public float getGreyScale()
        {
            float greyScale = (r + g + b) / numberOfColours;
            return greyScale;
        }
    }
}
