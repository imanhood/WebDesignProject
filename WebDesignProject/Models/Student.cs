namespace WebDesignProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    //[Serializable]
    public class Student
    {
        public Student()
        {
            //StudentCourses = new List<StudentCourse>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(256)]
        public string Title { get; set; }

        public int? EnterSemesterId { get; set; }

        //public virtual Semester Semester { get; set; }

        //public virtual ICollection<StudentCourse> StudentCourses { get; set; }
    }
}
