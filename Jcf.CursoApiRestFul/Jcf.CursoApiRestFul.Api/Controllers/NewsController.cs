using Jcf.CursoApiRestFul.Api.Entities.ViewModels;
using Jcf.CursoApiRestFul.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Jcf.CursoApiRestFul.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NewsController : ControllerBase
    {
        private readonly ILogger<NewsController> _logger;
        private readonly NewsService _newsService;

        public NewsController(ILogger<NewsController> logger, NewsService newsService)
        {
            _logger = logger;
            _newsService = newsService;
        }

        [HttpGet]
        public ActionResult<List<NewsViewModel>> Get() => _newsService.Get();

        [HttpPost]
        public ActionResult<NewsViewModel> Create(NewsViewModel newsViewModel) 
        { 
            var result = _newsService.Create(newsViewModel);
            return CreatedAtRoute("GetNews", new { id = result.Id, result });
        }

        [HttpGet("{id:length(24)}", Name = "GetNews")]
        public ActionResult<NewsViewModel> Get(string id)
        {
            var news = _newsService.Get(id);

            if(news is null)
                return NotFound();

            return news;
        }

        [HttpPut("{id:length(24)}")]
        public ActionResult<NewsViewModel> Update(string id, NewsViewModel newsViewModel) 
        {
            var news = _newsService.Get(id);

            if(news is null)
                return NotFound();

            _newsService.Update(id, newsViewModel);

            return CreatedAtRoute("GetNews", new { id = news.Id, newsViewModel });
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id) 
        {
            var news = _newsService.Get(id);

            if(news is null)
                return NotFound();

            _newsService.Remove(news.Id);

            return Ok("Notícia deletada com sucesso!"); 
        }
    }
}
