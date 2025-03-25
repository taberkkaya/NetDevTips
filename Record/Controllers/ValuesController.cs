using Microsoft.AspNetCore.Mvc;
using Record.Dtos;

namespace Record.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class ValuesController : ControllerBase
{
    [HttpGet("[action]")]
    public IActionResult Login(LoginDto loginDto)
    {
        LoginDto loginDto2 = new()
        {
            Email = "taberkkaya@gmail.com",
            Password = "1",
            RememberMe = true
        };

        loginDto.Email = string.Empty;
        return Ok("Giriş başarılı.");
    }    
    
    [HttpGet("[action]")]
    public IActionResult LoginWithRecord(Login login)
    {
        Login login2 = new("taberkkaya@gmail.com", "1" , true);
        //loginDto.Email = string.Empty;
        //loginDto2.Email = string.Empty;
        return Ok("Giriş başarılı.");
    }
}
