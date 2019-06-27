using Employee2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Employee2.ViewModels
{
    public class EmployeeFormViewModel
    {

       [Required]
        public string SurName { get; set; }

        [Required]
        public string FatherName { get; set; }

        [Required]
        public string MotherName { get; set; }

        [Required]
        public string Birthplace { get; set; }

        [Required]
        [PastDate]
        public string Date { get; set; }

        [Required]
        [ValidTime]
        public string Time { get; set; }

        [Required]
        public int Gender { get; set; }

        public IEnumerable<Gender> Genders { get; set; }


        public int BloodGroup { get; set; }

        public IEnumerable<BloodGroup> BloodGroups { get; set; }

        public DateTime GetDateTime()
        {
           
                return DateTime.Parse(string.Format("{0} {1}", Date, Time));
            
        }
    }
}