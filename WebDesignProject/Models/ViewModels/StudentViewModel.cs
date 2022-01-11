using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebDesignProject.Models.ViewModels {
    public class StudentViewModel {
        public StudentViewModel(Student student) {
            this.Id = student.Id;
            this.Title = student.Title;
            var courses = student.StudentCourses.Where(x => x.Mark.HasValue);
            if(courses.Any())
                this.AverageMark = courses.Average(x => x.Mark.Value);
            courses = student.StudentCourses.Where(x => x.Mark.HasValue && x.Mark >= 10);
            if(courses.Any())
                this.TotalCredit = courses.Sum(x => x.SemesterCourse.Course.CreditP + x.SemesterCourse.Course.CreditT);
            if(student.StudentCourses.Any())
                this.Semesters = student.StudentCourses.GroupBy(x=> x.SemesterCourse.SemesterId).Select(x=> new SemesterViewModel( x.ToList().First().SemesterCourse.Semester, x.ToList()));
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public IEnumerable<SemesterViewModel> Semesters { get; set; }
        public double AverageMark { get; set; }
        public int TotalCredit { get; set; }
    }
}