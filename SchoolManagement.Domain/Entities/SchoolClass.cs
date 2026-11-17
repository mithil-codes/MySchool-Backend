using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Domain.Entities
{
    public class SchoolClass
    {
        public int Id { get; set; }

        public string ClassName { get; set; } = string.Empty;
        public string Section { get; set; } = string.Empty;

        public int? ClassTeacherId { get; set; }
        public Teacher? ClassTeacher { get; set; }

        public ICollection<Student> Students { get; set; } = new List<Student>();
        public ICollection<ClassSubject> ClassSubject { get; set; } = new List<ClassSubject>();
    }
}
