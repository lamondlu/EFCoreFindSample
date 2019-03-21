using EFCore.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.Managers
{
    public class StudentManager
    {
        private IUnitOfWork _unitOfWork;

        public StudentManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void AddStudent(string studentName, Guid groupId)
        {
            var newStudentId = Guid.NewGuid();

            _unitOfWork.StudentRepository.AddStudent(newStudentId, studentName);
            _unitOfWork.GroupRepository.AssignStudentToGroup(newStudentId, groupId);

            _unitOfWork.Commit();
        }
    }
}
