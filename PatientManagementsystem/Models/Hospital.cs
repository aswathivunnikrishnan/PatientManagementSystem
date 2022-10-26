using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PatientManagementsystem.Models
{
    public class Hospital
    {
        [Required]
        public int Hospital_Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [RegularExpression("[A-Za-z ]{1,30}", ErrorMessage = "Give a proper  name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "State Name is required")]
        public string StateName { get; set; }

        [Required(ErrorMessage = "District is required")]
        public string District { get; set; }

        [Required(ErrorMessage = "city is required")]
        public int City { get; set; }

        [Required]
        public string ContactPerson { get; set; }

        [Required(ErrorMessage = " contact person's Phone number is required")]
        public string Contact_PhoneNumber { get; set; }

        [Required(ErrorMessage = " Office Phone number is required")]
        public string Office_PhoneNumber { get; set; }


        [Required]
        public int isactive { get; set; }
    }
}