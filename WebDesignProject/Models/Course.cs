namespace WebDesignProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    //[Table("Courses")]
    //[Serializable]
    public class Course
    {
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
