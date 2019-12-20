using BlogBL;
using System.Web.Mvc;

namespace BlogEducationALvl.Controllers
{
    public class ArticleController : Controller
    {
        private readonly ArticleService _articleService;
        public ArticleController()
        {
            _articleService = new ArticleService();
        }

        // GET: Article
        public ActionResult Index()
        {
         
            return View();
        }

        // GET: Article/Details/5
        // TODO: add view for this action 
        public ActionResult Details(int id)
        {
            _articleService.GetById(id);
            return View();
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
