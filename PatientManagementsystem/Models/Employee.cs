﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PatientManagementsystem.Models
{
    public class Employee
    {
        [Required]
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        [RegularExpression("[A-Za-z ]{1,30}", ErrorMessage = "Give a proper First name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        [RegularExpression("[A-Za-z ]{1,30}", ErrorMessage = "Give a proper last name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Gender is required")]
        public string Gender { get; set; }


        [Required(ErrorMessage = "Phone number is required")]
        public string PhoneNumber { get; set; }

        [Required]
        public string Address { get; set; }


        [Required(ErrorMessage = "Department is required")]
        public string Department { get; set; }


        [Required]
        public DateTime DOJ { get; set; }


        [Required]
        public string Designation { get; set; }

        [Required]
        public int isactive { get; set; }

        [Required]
        public string Password { get; set; }
    }
}