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

            IList<Category> categories = new List<Category>();

            for(int i = 0; i < 10; i++)
            {
                Category category = new()
                {
                    Name = "Category " + i,
                };
                categories.Add(category);
            }

            for (int i = 0; i < 1000000; i++)
            {
                Random random = new Random();

                Product product = new()
                {
                    Name = "Product " + i,
                    CategoryId = random.Next(1, 9),
                };

                products.Add(product);

                Console.WriteLine($"{product.Name} added to products list.");
            }
            context.Categories.AddRange(categories);
            context.Products.AddRange(products);
            context.SaveChanges();

            Console.WriteLine("Products list added to database.");
        }
    }
}
