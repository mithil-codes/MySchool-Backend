using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagement.Domain.Enums;


namespace SchoolManagement.Domain.Entities
{
    public class Student
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; } 

        public string AdmissionNumber { get; set; } = string.Empty;

        public string FatherName { get; set; } = string.Empty;
        public string FatherOccupation { get; set; } = string.Empty;

        public string MotherName { get; set; } = string.Empty;
        public string MotherOccupation { get; set; } = string.Empty;

        public string? GuardianDetails { get; set; }
        public string? GuardianRelation { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public bool IsActive { get; set; } = true;

        // Foreign Key
        public int ClassId { get; set; }

        // Navigation Property
        public SchoolClass Class { get; set; } = null!;

        public ICollection<StudentAddress> Addresses { get; set; }
    = new List<StudentAddress>();

        public ICollection<StudentPhone> PhoneNumbers { get; set; }
            = new List<StudentPhone>();


        // Identity Foreign Key
        public string? ApplicationUserId { get; set; }

        // Identity Navigation Property
        //public ApplicationUser? ApplicationUser { get; set; }






    }
}
