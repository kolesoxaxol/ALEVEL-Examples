using BlogBL.BLModels;
using BlogDAL.Entities;
using BlogDAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogBL
{
    // TODO: make it with generic services
    public class ArticleService 
    {
        private readonly IGenericRepository<Article> repository;
        public ArticleService()
        { 
            repository = new GenericRepository<Article>(); 
        }
        public ArticleBL GetById(int id)
        {
            var articleEntity = repository.FindById(id);
            // TODO: Install mapper\
            // TODO: finish mapping all fields
            return new ArticleBL()
            {
                AuthorId = articleEntity.AuthorId
            };
        }
    }
}
