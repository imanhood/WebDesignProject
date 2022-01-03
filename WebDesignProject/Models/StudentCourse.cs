namespace WebDesignProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    //[Table("StudentCourses")]
    //[Serializable]
    public class StudentCourse
    {
        public int Id { get; set; }

        public int StudentId { get; set; }

        public int SemesterCourseId { get; set; }

        public double? Mark { get; set; }

        //public virtual SemesterCourse SemesterCours { get; set; }

        //public virtual Student Student { get; set; }
    }
}
