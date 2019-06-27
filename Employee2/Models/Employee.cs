using System;
using System.ComponentModel.DataAnnotations;

namespace Employee2.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public ApplicationUser EmployeeUser { get; set; }

        [Required]
        public string EmployeeUserId { get; set; }

        [Required]
        [StringLength(255)]
        public string SurName { get; set; }

        [Required]
        [StringLength(255)]
        public string FatherName { get; set; }

        [Required]
        [StringLength(255)]
        public string MotherName { get; set; }

        [Required]
        [StringLength(255)]
        public string Birthplace { get; set; }

        public DateTime Birthdate { get; set; }

        public Gender Gender { get; set; }

        [Required]
        public int GenderId { get; set; }

        public BloodGroup BloodGroup { get; set; }

        [Required]
        public int BloodGroupId { get; set; }

    }

    
}