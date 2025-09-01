using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Components;

namespace CRUDOperation.Models
{
    public class PersonalInfo
    {
        public int ID { get; set; }

        [Required]
        [RegularExpression(@"^[0-9]{10}",ErrorMessage ="Number")]
        public long Mobile { get; set; }

        [Required]
        [StringLength(100,ErrorMessage ="Enter the valid name")]
        public string Name { get; set; }

        [Required]
        // [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,")]
        [EmailAddress(ErrorMessage = "Invalid EmailID")]
        public string MailID { get; set; }

        [Required(ErrorMessage = "Upload a correct format photo")]
        public string Photo { get; set; }
        [Required]
        public string Degree { get; set; }
        [Required]
        public string Department { get; set; }
        [Required]
        [Range(1, 1000000000, ErrorMessage = "Must be in number")]
        public Double Amount { get; set; }
        [Required]

        public DateTime DOB { get; set; } = System.DateTime.Today;

        [Required]
        public string[] SelectedDepartments { get; set; } = Array.Empty<string>();

        public enum GenderEnum
        {
            Male,
            Female,
            Other
        }
        [Required]
        public GenderEnum Gender { get; set; }
        [Required]
        public string Time { get; set; }
        [Required]
        public List<string> Languages { get; set; } = new();

        [Required]
        public DateTime DateTime { get; set; } = System.DateTime.Today;
        [Required]
        public string File { get; set; }







    }
}