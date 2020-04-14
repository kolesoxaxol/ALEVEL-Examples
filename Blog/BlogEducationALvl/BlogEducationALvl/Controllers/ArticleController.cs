using AutoMapper;
using BlogBL;
using BlogEducationALvl.Models;
using BlogEducationALvl.Responses;
using BlogEducationALvl.Services;
using System.Collections.Generic;
using System.Web.Mvc;

namespace BlogEducationALvl.Controllers
{
    public class ArticleController : Controller
    {
        private readonly IArticleService _articleService;
        private readonly IMapper _mapper;
        private readonly IEmailService _emailService;
        private readonly IArticleApiService _apiArticleService;
        public ArticleController(IArticleService articleService, IMapper mapper, IEmailService emailService, IArticleApiService apiArticleService)
        {
            _articleService = articleService;
            _mapper = mapper;
            _emailService = emailService;
            _apiArticleService = apiArticleService;
        }

        // GET: Article
        public ActionResult Index()
        {
            
            var listBLArticle = _articleService.GetAll();
            var articles = _mapper.Map<IEnumerable<ArticleModel>>(listBLArticle);

            ArticleResponse response = _apiArticleService.GetArticles();
            var apiArticles = response.Data;

            var fullArticleList = _mapper.Map<IEnumerable<ArticleModel>>(apiArticles);

            return View(fullArticleList);
        }

        // GET: Article/Details/5
 
        public ActionResult Details(int id)
        {
            var articleBL =  _articleService.FindById(id);
            var article = _mapper.Map<ArticleModel>(articleBL);
            //ArticleModel article = new ArticleModel
            //{
            //    AuthorId = articleBL.AuthorId,
            //    Body = articleBL.Body,
            //    Image = articleBL.Image,
            //    IsActive = articleBL.IsActive,
            //    SubTitle = articleBL.SubTitle,
            //    Title = articleBL.Title,
            //    Date = articleBL.Date,
            //    Id = articleBL.Id
            //};

            return View(article);
        }

        // GET: Article/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Article/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                string subject = "creted new article";
                string to = "dp260793kev@yandex.ua";
                string from = "test@mail.com";
                string body = "Please visit our blog we created new article";
                _emailService.SendSmtp(subject, body, from, to);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Article/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Article/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Article/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Article/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
