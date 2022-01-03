namespace WebDesignProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    //[Serializable]
    public class Semester
    {
        public Semester()
        {
            //SemesterCourses = new List<SemesterCourse>();
            //Students = new List<Student>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(256)]
        public string Title { get; set; }

        //public virtual ICollection<SemesterCourse> SemesterCourses { get; set; }

        //public virtual ICollection<Student> Students { get; set; }
    }
}
