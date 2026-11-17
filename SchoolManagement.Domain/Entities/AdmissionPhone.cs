using SchoolManagement.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Domain.Entities
{
    public class AdmissionPhone
    {
        public int Id { get; set; }

        public int AdmissionId { get; set; }

        public Admission Admission { get; set; } = null!;


        public string PhoneNumber { get; set; } = string.Empty; 
        public PhoneType PhoneType{ get; set; }
    }
}
