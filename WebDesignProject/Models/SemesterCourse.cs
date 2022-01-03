namespace WebDesignProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    //[Table("SemesterCourses")]
    //[Serializable]
    public class SemesterCourse
    {
        public SemesterCourse()
        {
            //StudentCourses = new List<StudentCourse>();
        }

        public int Id { get; set; }

        public int SemesterId { get; set; }

        public int CourseId { get; set; }

        public int ProfessorId { get; set; }

        public byte TimeType { get; set; }

        public byte WeekDay { get; set; }

        //public virtual Course Course { get; set; }

        //public virtual Professor Professor { get; set; }

        //public virtual Semester Semester { get; set; }

        //public virtual ICollection<StudentCourse> StudentCourses { get; set; }
    }
}
