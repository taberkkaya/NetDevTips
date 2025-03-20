using DataAccess.Context;
using DataAccess.Models;

namespace SingleOrUnique;

internal class Program
{
    static void Main(string[] args)
    {
        AppDbContext context = new();

        Product product = new()
        {
            Name = "Product 0",
        };
        context.Products.Add(product);
        context.SaveChanges();

        //Product? product = context.Products.Where(p => p.Name == "Product 0").FirstOrDefault();
        //Console.WriteLine(product?.Id.ToString() + " " + product?.Name);

        //product = context.Products.Where(p => p.Name == "Product 0").SingleOrDefault();
        //Console.WriteLine(product?.Id.ToString() + " " + product?.Name);


    }
}
