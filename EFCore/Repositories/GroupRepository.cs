using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.Repositories
{
    public class GroupRepository : IGroupRepository
    {
        private TestDbContext _dbContext;

        public GroupRepository(TestDbContext dbContext)
        {
            _dbContext = dbContext;
        }

    public void AssignStudentToGroup(Guid studentId, Guid groupId)
    {
        Student student = _dbContext.Students.Find(studentId);

        if (student == null)
        {
            throw new KeyNotFoundException("The student id could not be found.");
        }

        //if (_dbContext.ChangeTracker.Entries<Student>().Any(p => p.Entity.StudentId == studentId))
        //{
        //    student = _dbContext.ChangeTracker.Entries<Student>().First(p => p.Entity.StudentId == studentId).Entity;
        //}
        //else if (_dbContext.Students.Any(p => p.StudentId == studentId))
        //{
        //    student = _dbContext.Students.First(p => p.StudentId == studentId);
        //}
        //else
        //{
        //    throw new KeyNotFoundException("The student id could not be found.");
        //}

        student.StudentGroups.Add(new StudentGroup
        {
            StudentId = studentId,
            GroupId = groupId
        });
    }
    }
}
