
using System.Linq;
using System.Web.Mvc;
using WebDesignProject.Models.ViewModels;

namespace WebDesignProject.Controllers
{
    public class HomeController : Controller
    {        
        [HttpGet]
        public ActionResult Index()
        {
            var model = new HomeViewModel();
            using(SampleDatabase db = new SampleDatabase()) {
                model.Students = db.Students.AsNoTracking().ToList();
            }
            return View(model);
        }
    }
}