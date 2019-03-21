using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.Repositories
{
    public interface IGroupRepository
    {
        void AssignStudentToGroup(Guid studentId, Guid groupId);
    }
}
