using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.DTOs
{
    public class AddStudentDTO
    {
        public string Name { get; set; }

        public Guid GroupId { get; set; }
    }
}
