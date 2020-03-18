using System;
using System.Collections.Generic;

namespace MondayAddC.Models
{
    public class Game
    {
        public Guid ID { get; set; }
        public string Activity1 { get; set; }
        public string Activity2 { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}