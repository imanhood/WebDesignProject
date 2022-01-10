
using Newtonsoft.Json;
using System.Linq;
using System.Web.Mvc;
using WebDesignProject.Models.ViewModels;

namespace WebDesignProject.Controllers {
    public class StudentController : Controller {
        [HttpGet]
        public ActionResult Index(int id) {
            var db = new SampleDatabase();
            var student = db.Students.SingleOrDefault(x => x.Id == id);
            if(student == null) {
                Response.StatusCode = 400;
                return null;
            }
            var model = new StudentViewModel(student);
            model.Semesters = model.Semesters.OrderBy(x=> x.Id).ToList();
            return View(model);
        }
    }
}