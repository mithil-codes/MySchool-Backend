using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Domain.Entities
{
    public class Teacher
    {

        public int Id { get; set; }

        // Personal Details
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;

        // Professional Details
        public string Qualification { get; set; } = string.Empty;
        public DateTime JoiningDate { get; set; }

        // Common
        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Class Teacher Navigation Property
        public SchoolClass? ClassAsClassTeacher { get; set; }


        // Subject Teacher Navigation Property
        public ICollection<ClassSubject> ClassSubjects
        { get; set; } = new List<ClassSubject>();

        // Identity Foreign Key
        public string? ApplicationUserId { get; set; }
    }
}


