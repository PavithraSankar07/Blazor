using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CRUDOperation.Models
{
    public class PersonalInfo
    {
          public int ID { get; set; }
        // [Range(47, 99, ErrorMessage = "ID must be between 47 and 100.")]
        public string Mobile { get; set; }
        public string Name { get; set; }
        public string MailID { get; set; }
        public string Photo { get; set; }
        public string Degree { get; set; }
        public string Department { get; set; }
        public Double Amount { get; set; }
        public DateTime DOB { get; set; } = System.DateTime.Today;
        public string[] SelectedDepartments { get; set; } = Array.Empty<string>();
        public enum GenderEnum
        {
            Male,
            Female,
            Other
        }
        public GenderEnum Gender { get; set; }
        public string Time { get; set; }
        public List<string> Languages { get; set; } = new();
        public DateTime DateTime { get; set; } = System.DateTime.Today;
        public string? File { get; set; }
    }
}