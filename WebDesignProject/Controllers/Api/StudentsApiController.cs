using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebDesignProject.Controllers
{
    //[Route("api/{controller}")]
    public class StudentsApiController : ApiController
    {

        SampleDatabase db = new SampleDatabase();

        [HttpGet]
        public IHttpActionResult GetStudents()
        {
            return Ok(db.Students);
        }

        public IHttpActionResult Get(int studentId)
        {
            return Ok(db.Students.Where(t => t.Id == studentId));
        }

        public IHttpActionResult GetCourses(int studentId)
        {
            return Ok(db.StudentCourses.Where(t => t.StudentId == studentId));
        }

        // POST api/<controller>
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}