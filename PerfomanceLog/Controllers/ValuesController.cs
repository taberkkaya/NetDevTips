using DataAccess.Context;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace PerfomanceLogWebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ValuesController : ControllerBase
{
    [HttpGet("[action]")]
    public async Task<IActionResult> GetAllAsync(CancellationToken cancellationToken)
    {
        AppDbContext context = new();
        IList<PerfomanceLog> perfomanceLogs = await context
            .PerfomanceLogs
            .OrderByDescending(x => x.Id)
            .ToListAsync(cancellationToken);

        return Ok(perfomanceLogs);
    }

    [HttpGet("[action]")]
    public async Task<IActionResult> GetAllProductsAsync(CancellationToken cancellationToken)
    {
        AppDbContext context = new();
        IList<Product> products = await context.Products
            .ToListAsync(cancellationToken);

        return Ok(products.Take(10));
    }
}
