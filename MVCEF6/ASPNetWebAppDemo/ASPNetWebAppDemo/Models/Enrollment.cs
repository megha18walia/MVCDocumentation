using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPNetWebAppDemo.Models
{
    public enum Grade { A,B,C,D,E,F}
    public class Enrollment
    {
        public int EnrollmentId { get; set; }
        public int CourseId { get; set; }
        public int StudentId { get; set; }
        public Grade? Grade { get; set; }

        //Navigational Property
        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}