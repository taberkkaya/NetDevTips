using DataAccess.Context;
using DataAccess.Models;

namespace ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            AppDbContext context = new();

            IList<Product> products = new List<Product>();


            for (int i = 0; i < 1000000; i++)
            {
                Product product = new()
                {
                    Name = "Product " + i,
                };

                products.Add(product);

                Console.WriteLine($"{product.Name} added to products list.");
            }
            context.Products.AddRange(products);
            context.SaveChanges();

            Console.WriteLine("Products list added to database.");
        }
    }
}
