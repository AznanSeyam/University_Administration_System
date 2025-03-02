using System.Collections.Generic;
using UniversityManagementSystem.Models;

namespace UniversityManagementSystem.Services
{
    public interface IEnrollmentService
    {
        IEnumerable<Enrollment> GetAllEnrollments();
        void EnrollStudent(Enrollment enrollment);
        void RemoveEnrollment(int id);
    }
}
