using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ApiCountry.Models
{
    public enum regiontype
    {
        America = 1,
        Europa = 2,
        Africa = 3,
        Asia = 4,
        Oceania = 5

    };
    public class Country
    {
        [Key]
        [Required(ErrorMessage ="You must enter the field {0}")]
        [StringLength(3, ErrorMessage ="The field {0} must contain between {2} and {1} characters", MinimumLength =3)]
        public string alpha3code { get; set; }

        [Required(ErrorMessage = "You must enter the field {0}")]
        public regiontype region { get; set; }

        [Required(ErrorMessage = "You must enter the field {0}")]
        public string name { get; set; }

        [Required(ErrorMessage = "You must enter the field {0}")]
        public double area { get; set; }

        [Required(ErrorMessage = "You must enter the field {0}")]
        public int callingcodes { get; set; }

        [Required(ErrorMessage = "You must enter the field {0}")]
        public string languages { get; set; }

        [Required(ErrorMessage = "You must enter the field {0}")]
        [Url]
        public string flag { get; set; }

    }
}