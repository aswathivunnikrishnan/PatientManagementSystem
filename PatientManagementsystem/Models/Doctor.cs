﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PatientManagementsystem.Models
{
    public class Doctor
    {
        [Required]
        public int Doctor_id { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        [RegularExpression("[A-Za-z ]{1,30}", ErrorMessage = "Give a proper name")]
        public string Doctor_Name { get; set; }

        [Required(ErrorMessage = "Last Speciality is required")]
        public string Speciality { get; set; }


        [Required(ErrorMessage = "Qualification is required")]
        public String Qualification { get; set; }

        [Required(ErrorMessage = "Phone number is required")]
        [RegularExpression("^(\\+91[\\-\\s]?)?[0]?(91)?[789]\\d{9}$", ErrorMessage = "Give a proper Phone Number")]
        public string D_PhoneNumber { get; set; }

        public DateTime Timeofconsultancy { get; set; }

        public int No_of_patientperday { get; set; }

        public int Fee { get; set; }

        public string Password { get; set; }

        [Required]
        public int DeletedStatus { get; set; }
    }
}