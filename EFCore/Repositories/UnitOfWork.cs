using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private TestDbContext _dbContext = null;
        private IStudentRepository _studentRepository = null;
        private IGroupRepository _groupRepository = null;

        public UnitOfWork(TestDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IStudentRepository StudentRepository
        {
            get
            {
                if (_studentRepository == null)
                {
                    _studentRepository = new StudentRepository(_dbContext);
                }

                return _studentRepository;
            }
        }

        public IGroupRepository GroupRepository
        {
            get
            {
                if (_groupRepository == null)
                {
                    _groupRepository = new GroupRepository(_dbContext);
                }

                return _groupRepository;
            }
        }

        public void Commit()
        {
            _dbContext.SaveChanges();
        }
    }
}
