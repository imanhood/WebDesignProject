namespace WebDesignProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SemesterCourses")]
    public partial class SemesterCourse
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SemesterCourse()
        {
            StudentCourses = new HashSet<StudentCourse>();
        }

        public int Id { get; set; }

        public int SemesterId { get; set; }

        public int CourseId { get; set; }

        public int ProfessorId { get; set; }

        public byte TimeType { get; set; }

        public byte WeekDay { get; set; }

        public virtual Course Course { get; set; }

        public virtual Professor Professor { get; set; }

        public virtual Semester Semester { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StudentCourse> StudentCourses { get; set; }
    }
}
