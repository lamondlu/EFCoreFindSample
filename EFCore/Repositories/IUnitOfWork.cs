using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.Repositories
{
    public interface IUnitOfWork
    {
        IStudentRepository StudentRepository { get; }

        IGroupRepository GroupRepository { get; }

        void Commit();
    }
}
