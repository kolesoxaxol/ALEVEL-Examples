using ALvlBlog.WebApi.Models;
using ALvlBlog.WebApi.Responses;
using ALvlBlog.WebApi.Services;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;

namespace ALvlBlog.WebApi.Controllers
{
    public class ArticleController : ApiController
    {
        private readonly IArticleService _articleService;

        public ArticleController(IArticleService articleService)
        {
            _articleService = articleService;           
        }

        // GET: api/Article
        public async Task<BaseResponse<List<ArticleModel>>> Get()
        {
            var articles = await _articleService.GetAllArticles();
            return new BaseResponse<List<ArticleModel>> { Data = articles.ToList() };
        }

        // GET: api/Article/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Article
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Article/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Article/5
        public void Delete(int id)
        {
        }
    }
}
