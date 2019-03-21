using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.Repositories
{
    public interface IStudentRepository
    {
        void AddStudent(Guid studentId, string name);
    }
}
