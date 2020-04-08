using ALvlBlog.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace ALvlBlog.WebApi.Services
{
    public interface IArticleService
    {
        Task<IEnumerable<ArticleModel>> GetAllArticles();
    }
    public class ArticleService : IArticleService
    {
        public async Task<IEnumerable<ArticleModel>> GetAllArticles()
        {
            var response = await Task.Run(() => new List<ArticleModel>
            {
                new ArticleModel {AuthorId =1, Body= "body 1", Date = DateTime.Now, Image="", IsActive= true, SubTitle="subTitle", Title="Title", Id =1  },
                new ArticleModel {AuthorId =1, Body= "body 1", Date = DateTime.Now, Image="", IsActive= true, SubTitle="subTitle", Title="Title", Id =1  },
                new ArticleModel {AuthorId =1, Body= "body 1", Date = DateTime.Now, Image="", IsActive= true, SubTitle="subTitle", Title="Title", Id =1  },
                new ArticleModel {AuthorId =1, Body= "body 1", Date = DateTime.Now, Image="", IsActive= true, SubTitle="subTitle", Title="Title", Id =1  }

            } ); // wait asynchronously

            return response;
        }
    }
}