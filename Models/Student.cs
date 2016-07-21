using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; } // primnary key column of the database table
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        /*
         * Navifation property. They hold other entities that are related to this entitiy
         * Enrollments property of a student entity with hold all of the Enrollment entities that are related to that Student entitiyt
         * If a given student row in the database has two related enrollment rows, the student's entitiy's enrollments navigation property will contain those two enrollment entities
         */
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}