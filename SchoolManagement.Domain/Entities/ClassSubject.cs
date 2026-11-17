using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Domain.Entities
{
 
        public class ClassSubject
        {
            public int Id { get; set; }

            // Class Foreign Key
            public int ClassId { get; set; }

            // Class Navigation Property
            public SchoolClass Class { get; set; } = null!;

            // Subject Foreign Key
            public int SubjectId { get; set; }

            // Subject Navigation Property
            public Subject Subject { get; set; } = null!;

            // Teacher Foreign Key
            public int TeacherId { get; set; }

            // Teacher Navigation Property
            public Teacher Teacher { get; set; } = null!;
        }
    }


