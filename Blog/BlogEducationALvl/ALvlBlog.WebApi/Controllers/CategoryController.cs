using ALvlBlog.WebApi.Services;
using System.Collections.Generic;
using System.Web.Http;

namespace ALvlBlog.WebApi.Controllers
{
    public class CategoryController : ApiController
    {
        private readonly IArticleService _articleServcie;

        public CategoryController(IArticleService articleService)
        {
            _articleServcie = articleService;
        }

        // GET: api/Category
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Category/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Category
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Category/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Category/5
        public void Delete(int id)
        {
        }
    }
}
