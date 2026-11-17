using SchoolManagement.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Domain.Entities
{
     public class StudentAddress
        {
            public int Id { get; set; }

            // Foreign Key
            public int StudentId { get; set; }

            // Navigation Property
            public Student Student { get; set; } = null!;

            // Address Details
            public AddressType AddressType { get; set; } 

            public string Street { get; set; } = string.Empty;
            public string City { get; set; } = string.Empty;
            public string State { get; set; } = string.Empty;
            public string Country { get; set; } = string.Empty;
            public string PinCode { get; set; } = string.Empty;
     }
}


