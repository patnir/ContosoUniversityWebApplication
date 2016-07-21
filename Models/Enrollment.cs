using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A, B, C, D, E, F
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set;}

        // Question mark indicates that the grade property is nullable
        public Grade? Grade { get; set; }

        // Only single student or course can be held in the following two foreign keys
        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}