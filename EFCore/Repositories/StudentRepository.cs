using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private TestDbContext _dbContext;

        public StudentRepository(TestDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddStudent(Guid studentId, string name)
        {
            _dbContext.Students.Add(new Student
            {
                StudentId = studentId,
                Name = name,
                Credits = 0
            });
        }
    }
}
