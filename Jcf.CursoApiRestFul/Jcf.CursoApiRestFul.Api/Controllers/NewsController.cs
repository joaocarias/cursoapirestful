using Microsoft.AspNetCore.Mvc;

namespace Jcf.CursoApiRestFul.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NewsController : ControllerBase
    {
        private readonly ILogger<NewsController> _logger;

        public NewsController(ILogger<NewsController> logger)
        {
            _logger = logger;
        }


       
    }
}
