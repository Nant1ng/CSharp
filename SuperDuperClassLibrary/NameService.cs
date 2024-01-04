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
        public List<string> GetAllNames()
        {
            return context.Products.Select(p => p.ProductName).ToList();
        }
        public string GetName(int id)
        {
            foreach (var p2 in context.CurrentProductLists)
            {
                Console.WriteLine(p2.ProductName);
            }
            var p = context.Products.FirstOrDefault(p => p.ProductId == id);
            if (p == null) return "";
            return p.ProductName;
        }
    }
}
