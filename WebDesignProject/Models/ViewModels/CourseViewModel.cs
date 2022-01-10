using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebDesignProject.Models.ViewModels {
    public class CourseViewModel {
        public CourseViewModel(StudentCourse studentCourse) {
            this.Title = studentCourse.SemesterCourse.Course.Title;
            this.Mark = studentCourse.Mark;
            this.CreditP = studentCourse.SemesterCourse.Course.CreditP;
            this.CreditT = studentCourse.SemesterCourse.Course.CreditT;
            this.ProfessorTitle = studentCourse.SemesterCourse.Professor.Title;
        }
        public string Title { get; set; }
        public double? Mark { get; set; }
        public int CreditT { get; set; }
        public int CreditP { get; set; }
        public string ProfessorTitle { get; set; }
    }
}