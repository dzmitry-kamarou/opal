using Microsoft.AspNetCore.Mvc;
using Opal.Models;

namespace Opal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthCheckController : ControllerBase
    {
        private readonly HealthCheckContext _context;

        public HealthCheckController(HealthCheckContext context)
        {
            _context = context;
        }

        [HttpGet]
        public string GetHealthCheck()
        {
            return "Welcome to the Opal, it's feeling good!";
        }
    }
}