using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore
{
    public class TestDbContext : DbContext
    {

        public TestDbContext(DbContextOptions<TestDbContext> options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Group> Groups { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentGroup>().HasKey(p => new { p.GroupId, p.StudentId });
            modelBuilder.Entity<Group>().HasData(new Group { GroupId = Guid.Parse("{366EBFBE-DFE6-4E04-97E9-5EDD07CE88C0}"), GroupName = "Math Group" });

            base.OnModelCreating(modelBuilder);
        }
    }


    [Table("Student")]
    public class Student
    {
        [Key]
        public Guid StudentId { get; set; }

        public string Name { get; set; }

        public int Credits { get; set; }

        public virtual ICollection<StudentGroup> StudentGroups { get; set; }
    }

    [Table("Group")]
    public class Group
    {
        [Key]
        public Guid GroupId { get; set; }

        public string GroupName { get; set; }
    }

    [Table("StudentGroup")]
    public class StudentGroup
    {
        public Guid StudentId { get; set; }

        public Guid GroupId { get; set; }

        [ForeignKey("StudentId")]
        public virtual Student Student { get; set; }

        [ForeignKey("GroupId")]
        public virtual Group Group { get; set; }
    }
}
