namespace WebDesignProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Student
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Student()
        {
            StudentCourses = new HashSet<StudentCourse>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(256)]
        public string Title { get; set; }

        public int? EnterSemesterId { get; set; }

        public virtual Semester Semester { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StudentCourse> StudentCourses { get; set; }
    }
}
