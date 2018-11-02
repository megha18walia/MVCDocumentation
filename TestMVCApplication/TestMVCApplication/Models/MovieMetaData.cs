using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestMVCApplication.Models
{
    public class MovieMetaData
    {
        [Required(ErrorMessage = "Movie Name is required")]
        [Display(Name ="Movie")]
        public string Movie1
        { get; set; }

        [Required(ErrorMessage ="Please Add the Genere")]
        public string Genere
        { get; set; }

        [Required(ErrorMessage ="Please entre the Price")]
        [Range(100, 1000,ErrorMessage ="Movies Ticket can lie between 100 and 1000 INR") ]
        public Nullable<decimal> Price
        { get; set; }
    }
}