using Microsoft.AspNetCore.Mvc;
using UniversityManagementSystem.Data;
using UniversityManagementSystem.Models;
using System.Collections.Generic;
using System.Linq;

namespace UniversityManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnrollmentsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public EnrollmentsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Enrollment>> GetEnrollments()
        {
            return _context.Enrollments.ToList();
        }

        [HttpPost]
        public IActionResult EnrollStudent(Enrollment enrollment)
        {
            _context.Enrollments.Add(enrollment);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetEnrollments), new { id = enrollment.Id }, enrollment);
        }
    }
}
