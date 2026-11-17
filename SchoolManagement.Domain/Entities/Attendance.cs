using SchoolManagement.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Domain.Entities
{
    public class Attendance
    {
        public int Id { get; set; }

        public int StudentId { get; set; }
        public Student Student { get; set; } = null!;

        public int ClassId { get; set; }
        public SchoolClass Class { get; set; } = null!;

        public DateTime AttendanceDate { get; set; }
        public AttendanceStatus Status { get; set; }

        public string? Remarks { get; set; }

        public int? MarkedByTeacherId { get; set; }
        public Teacher? MarkedByTeacher { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
