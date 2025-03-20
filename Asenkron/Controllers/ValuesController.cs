using DataAccess.Context;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Asenkron.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class ValuesController : ControllerBase
{

    [HttpGet("GetFirst")]
    public IActionResult GetFirst()
    {
        //sync
        AppDbContext context = new();
        Product product = context.Products.First();
        return Ok(product);
    }


    [HttpGet("GetFirstAsync")]
    public async Task<IActionResult> GetFirstAsync()
    {
        //async
        AppDbContext context = new();
        Product product = await context.Products.FirstAsync();
        return Ok(product);
    }
}
