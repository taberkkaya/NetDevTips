using DataAccess.Context;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace EagerLazyLoading;

internal class Program
{
    static void Main(string[] args)
    {
        AppDbContext context = new();

        IList<Product> products = context
            .Products
            .ToList(); // Lazy Loading

        IList<Product> products2 = context
            .Products
            .Include(p => p.Category)
            .ToList(); // Eager Loading
    }
}
