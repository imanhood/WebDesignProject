using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebDesignProject.Models.ViewModels {
    public class SemesterViewModel {
        public SemesterViewModel(Semester semester, IEnumerable<StudentCourse> studentCourses) {
            this.Id = semester.Id;
            this.Title = semester.Title;
            this.AverageMark = studentCourses.Where(x => x.Mark.HasValue).Average(x => x.Mark.Value);
            this.TotalCredit = studentCourses.Where(x => x.Mark.HasValue && x.Mark >= 10).Sum(x => x.SemesterCourse.Course.CreditP + x.SemesterCourse.Course.CreditT);
            this.Courses = studentCourses.Select(x=> new CourseViewModel(x));
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public double AverageMark { get; set; }
        public int TotalCredit { get; set; }
        public IEnumerable<CourseViewModel> Courses { get; set; }
    }
}