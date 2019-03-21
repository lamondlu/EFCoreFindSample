using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCore.DTOs;
using EFCore.Managers;
using Microsoft.AspNetCore.Mvc;

namespace EFCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private StudentManager _studentManager = null;

        public StudentController(StudentManager studentManager)
        {
            _studentManager = studentManager;
        }

        // GET api/values
        [HttpPost]
        public IActionResult Post([FromBody]AddStudentDTO dto)
        {
            try
            {
                _studentManager.AddStudent(dto.Name, dto.GroupId);

                return StatusCode(201);
            }
            catch
            {
                return StatusCode(500, new { message = "Unexpected Issue." });
            }
        }
    }
}
