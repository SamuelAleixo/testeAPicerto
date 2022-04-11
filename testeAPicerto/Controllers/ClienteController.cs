using Microsoft.AspNetCore.Mvc;

namespace testeAPicerto.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        
        [HttpGet(Name = "GetWeatherForecast")]
        public int Get()
        {
            return 12345;
        }
    }
}