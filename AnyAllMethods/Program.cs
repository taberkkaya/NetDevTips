using DataAccess.Context;

namespace AnyAllMethods;

internal class Program
{
    static void Main(string[] args)
    {
        AppDbContext context = new();
        
        bool result = context.Products.Any();

        bool result2 = context.Products.Any(x => x.Name == "Product 1");

        bool result3 = context.Products.All(x => x.Name.Contains("P")); //true
        bool result4 = context.Products.All(x => x.Name.Contains("Product 1")); //false

        Console.WriteLine("Hello, World!");
    }
}
