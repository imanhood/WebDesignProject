namespace WebDesignProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Courses")]
    public partial class Course
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Course(){}

        public int Id { get; set; }

        [Required]
        [StringLength(256)]
        public string Title { get; set; }

        public byte CreditT { get; set; }

        public byte CreditP { get; set; }

        public int Cost { get; set; }
    }
}
