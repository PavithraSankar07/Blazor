using System.ComponentModel.DataAnnotations;

namespace CRUDOperation.Models
{
    public class PersonalInfo
    {
        // private static int s_id = 1;
        // [Required]
        public int ID { get; set; }
        // [Range(47, 99, ErrorMessage = "ID must be between 47 and 100.")]
        public long Mobile { get; set; }
        public string Name { get; set; }
        public string MailID { get; set; }
        public string Photo { get; set; }
        public string Department { get; set; }
        public string Comment { get; set; }

        // public PersonalInfo()
        // {
        //     ID = s_id++;
        // }
        
        
        
        
    }
}