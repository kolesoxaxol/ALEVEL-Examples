using BlogBL.BLModels;
using BlogDAL.Entities;
using BlogDAL.Repository;

namespace BlogBL
{
    public interface IArticleService : IGenereicService<ArticleBL>
    { 
        
    }
    public class ArticleService: GenericService<ArticleBL, Article>, IArticleService
    {
        private readonly IGenericRepository<Article> repository;
        public ArticleService()
        { 
            repository = new GenericRepository<Article>(); 
        }

        public override ArticleBL Map(Article model)
        {
            // TODO : use mapper 
            return new ArticleBL()
            {   
                AuthorId = model.AuthorId,
                Body = model.Body,
                Image = model.Image,
                IsActive = model.IsActive,
                SubTitle = model.SubTitle,
                Title = model.Title,
                Date = model.Date,
                Id = model.Id
            };
        }

        public override Article Map(ArticleBL model)
        {
            throw new System.NotImplementedException();
        }

    }
}
