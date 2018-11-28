using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPNetWebAppDemo.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string  FirstName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        //Navigational Property
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}