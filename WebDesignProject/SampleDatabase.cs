using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WebDesignProject {
    public partial class SampleDatabase : DbContext {
        public SampleDatabase()
            : base("name=DbConnection") {
        }

        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Professor> Professors { get; set; }
        public virtual DbSet<SemesterCourse> SemesterCourses { get; set; }
        public virtual DbSet<Semester> Semesters { get; set; }
        public virtual DbSet<StudentCourse> StudentCourses { get; set; }
        public virtual DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            modelBuilder.Entity<Course>()
                .HasMany(e => e.SemesterCourses)
                .WithRequired(e => e.Course)
                .HasForeignKey(e => e.CourseId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Course>()
                .HasMany(e => e.ParentCourses)
                .WithMany(e => e.ChildCourses)
                .Map(m => m.ToTable("PreCourses").MapLeftKey("CourseId").MapRightKey("ParentCourseId"));

            modelBuilder.Entity<Professor>()
                .HasMany(e => e.SemesterCourses)
                .WithRequired(e => e.Professor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SemesterCourse>()
                .HasMany(e => e.StudentCourses)
                .WithRequired(e => e.SemesterCourse)
                .HasForeignKey(e => e.SemesterCourseId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Semester>()
                .HasMany(e => e.SemesterCourses)
                .WithRequired(e => e.Semester)
                .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Semester>()
            //    .HasMany(e => e.Students)
            //    .WithOptional(e => e.Semester)
            //    .HasForeignKey(e => e.EnterSemesterId);

            modelBuilder.Entity<Student>()
                .HasMany(e => e.StudentCourses)
                .WithRequired(e => e.Student)
                .WillCascadeOnDelete(false);
        }
    }
}
