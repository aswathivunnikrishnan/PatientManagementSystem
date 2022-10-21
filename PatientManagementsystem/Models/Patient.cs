using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PatientManagementsystem.Models
{
    public class Patient
    {
        [Required]
        public int Patient_id { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        [RegularExpression("[A-Za-z ]{1,30}", ErrorMessage = "Give a proper First name")]
        public string FName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        [RegularExpression("[A-Za-z ]{1,30}", ErrorMessage = "Give a proper last name")]
        public string LName { get; set; }

        [Required(ErrorMessage = "Gender is required")]
        //[GenderValidation(ErrorMessage = "Enter valid gender")]
        public string Patient_Gender { get; set; }

        [Required(ErrorMessage = "Age is required")]
        [Range(0, 120, ErrorMessage = "Not valid")]
        public int Patient_Age { get; set; }

        [Required]
        public string Patient_Address { get; set; }

        [Required(ErrorMessage = "Phone number is required")]
        [Range(0, 120, ErrorMessage = "Not valid")]
        public int PhoneNumber { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [RegularExpression("([-!#-'*+/-9=?A-Z^-~]+(\\.[-!#-'*+/-9=?A-Z^-~]+)*|\"([]!#-[^-~ \\t]|(\\\\[\\t -~]))+\")@([-!#-'*+/-9=?A-Z^-~]+(\\.[-!#-'*+/-9=?A-Z^-~]+)*|\\[[\\t -Z^-~]*])", ErrorMessage = "Give a proper Email Id")]
        public string Email { get; set; }

        [Required]
        public int DeletedStatus { get; set; }
    }
}