using SuperDuperClassLibrary.Data;

namespace SuperDuperClassLibrary
{
    public class NameService
    {
        NorthwindContext context;
        public NameService()
        {
            context = new NorthwindContext();
        }
        public string GetName(int id)
        {

            var p = context.Products.FirstOrDefault(p => p.ProductId == id);
            if (p == null) return "";
            return p.ProductName;

        }
    }
}
