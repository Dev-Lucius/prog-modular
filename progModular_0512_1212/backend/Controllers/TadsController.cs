using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers;

[ApiController]
[Route("[controller]")]
public class TadsController : ControllerBase
{
    [HttpGet(Name = "GetTads")]
    public string Get()
    {
        return "análise e Desenvolvimento de Sistemas";
        
    }
}
