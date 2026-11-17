using SchoolManagement.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Domain.Entities
{
    public class Admission
    {

        public int Id { get; set; }

        // Application Details
        public string ApplicationNumber { get; set; } = string.Empty;

        // Student Personal Details
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; } = string.Empty;

        // Father Details
        public string FatherName { get; set; } = string.Empty;
        public string FatherOccupation { get; set; } = string.Empty;

        // Mother Details
        public string MotherName { get; set; } = string.Empty;
        public string MotherOccupation { get; set; } = string.Empty;

        // Guardian Details (Optional)
        public string? GuardianDetails { get; set; }
        public string? GuardianRelation { get; set; }

        // Previous School
        public string? PreviousSchool { get; set; }

        // Admission Request
        public int RequestedClassId { get; set; }
        public string AcademicYear { get; set; } = string.Empty;

        // Admission Status
        public AdmissionStatus AdmissionStatus { get; set; } = AdmissionStatus.Pending;

        // Admin Approval Details
        public string? ApprovedBy { get; set; }
        public DateTime? ApprovedAt { get; set; }
        public string? RejectionReason { get; set; }

        // Multiple Addresses
        public ICollection<AdmissionAddress> Addresses { get; set; }
            = new List<AdmissionAddress>();

        // Multiple Phone Numbers
        public ICollection<AdmissionPhone> PhoneNumbers { get; set; }
            = new List<AdmissionPhone>();

        // Common
        public DateTime AppliedAt { get; set; } = DateTime.UtcNow;
    }
}
