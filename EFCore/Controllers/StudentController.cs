using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EFCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        public StudentController()
        {

        }

        // GET api/values
        [HttpPost]
        public IActionResult Get()
        {
            throw new NotImplementedException();
        }
    }
}
