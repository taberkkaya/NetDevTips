using DataAccess.Context;
using DataAccess.Models;

namespace AsReadOnly;

internal class Program
{
    static void Main(string[] args)
    {
        AppDbContext context = new();
        //IList<Product> products = context.Products.ToList();
        IReadOnlyList<Product> products = context.Products.ToList().AsReadOnly();

        products[0].Name = "Test";

        Console.WriteLine(products[0].Name);

        //Product product = new()
        //{
        //    Name = "Test2"
        //};

        //products.Add(product);


    }
}