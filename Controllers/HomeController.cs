using Microsoft.AspNetCore.Mvc;

namespace docker.api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        public HomeController()
        {

        }

        [HttpGet]
        public string Get()
        {
            return DateTime.Now.Second.ToString();
        }

    }
}