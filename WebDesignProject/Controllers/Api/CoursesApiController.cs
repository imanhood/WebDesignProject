using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebDesignProject.Controllers
{
    public class CoursesApiController : ApiController
    {
        SampleDatabase db = new SampleDatabase();

        //[HttpGet]
        //[Route("GetStudents")]
        public object GetStudents()
        {
            return db.Courses;
        }
    }
}
