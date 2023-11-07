namespace GenericsArray
{
    public class ArraysGeneric
    {
        public T[] CreateArrayGeneric<T>(T itemOne, T itemTwo)
        {
            return new T[] { itemOne, itemTwo };
        }
        public int[] CreateArray(int itemOne, int itemTwo)
        {
            return new int[] { itemOne, itemTwo };
        }

        public double[] CreateArray(double itemOne, double itemTwo)
        {
            return new double[] { itemOne, itemTwo };
        }

        public string[] CreateArray(string itemOne, string itemTwo)
        {
            return new string[] { itemOne, itemTwo };
        }
    }
}
