using System;

namespace MondayAddC.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        public Guid ID { get; set; }
        public Guid CourseID { get; set; }
        public Guid StudentID { get; set; }
        public Guid GameID {get; set;}
        public Grade? Grade { get; set; }
        

        public Course Course { get; set; }
        public Student Student { get; set; }

        public Game Game {get; set;}
    }
}