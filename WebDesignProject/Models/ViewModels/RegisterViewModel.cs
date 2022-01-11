using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebDesignProject.Models.ViewModels {
    public enum PermitTypeEnum {
        Allowed,
        Passed,
        HaveNotPassedPreCourses
    }
    public class RegisterViewModel {
        public RegisterViewModel(Semester semester, Student student) {
            var courses = student.StudentCourses.Where(x => x.SemesterCourse.SemesterId == semester.Id);
            if(courses.Any())
                this.Timesheets = courses.Select(x => x.SemesterCourseId).ToArray();
            this.Courses = semester.SemesterCourses.Select(x => x.Course).Distinct().Select(x=> new RegisterCourseViewModel(x, x.SemesterCourses.Where(y=> y.SemesterId == semester.Id && y.CourseId == x.Id), student));
        }
        public int[] Timesheets { get; set; }
        public IEnumerable<RegisterCourseViewModel> Courses { get; set; }

    }
    public class RegisterCourseViewModel { 
        public RegisterCourseViewModel(Course course, IEnumerable<SemesterCourse> semesterCourses, Student student) {
            this.Id = course.Id;
            this.Title = course.Title;
            this.Credit = course.CreditT + course.CreditP;
            this.Cost = course.Cost;
            if(student.StudentCourses.Where(x=> x.Mark.HasValue && x.Mark >= 10).Select(x=> x.SemesterCourse.CourseId).Contains(course.Id))
                this.PermitType = PermitTypeEnum.Passed;
            else if (course.ParentCourses.Any() && course.ParentCourses.Select(x => x.Id).Except(student.StudentCourses.Where(x => x.Mark.HasValue && x.Mark >= 10).Select(x => x.SemesterCourse.CourseId)).Any())
                this.PermitType = PermitTypeEnum.HaveNotPassedPreCourses;
            else
                this.PermitType = PermitTypeEnum.Allowed;
            this.Professors = semesterCourses.Select(x => x.Professor).Distinct().Select(x=> new RegisterProfessorViewModel(x, semesterCourses.Where(y=> y.ProfessorId == x.Id)));
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public double Credit { get; set; }
        public int Cost { get; set; }
        public PermitTypeEnum PermitType { get; set; }
        public IEnumerable<RegisterProfessorViewModel> Professors { get; set; }
    }
    public class RegisterProfessorViewModel {
        public RegisterProfessorViewModel(Professor professor, IEnumerable<SemesterCourse> semesterCourses) {
            this.Id = professor.Id;
            this.Title = professor.Title;
            this.Timesheets = semesterCourses.Select(x => new RegisterTimesheet(x));
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public IEnumerable<RegisterTimesheet> Timesheets { get; set; }
    }
    public class RegisterTimesheet {
        public RegisterTimesheet(SemesterCourse semesterCourse) {
            this.Id = semesterCourse.Id;
            this.TimeType = semesterCourse.TimeType;
            this.WeekDay = semesterCourse.WeekDay;
        }
        public int Id { get; set; }
        public int TimeType { get; set; }
        public int WeekDay { get; set; }
    }
}