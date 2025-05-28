using System.ComponentModel.DataAnnotations;

public class PersonalInfo
{
      
        public int ID { get; set; }
 
        public string Mobile { get; set; }
  
        public string Name { get; set; }
   
        public string MailID { get; set; }
     
       public string Photo { get; set; }

     
        public string Degree { get; set; }
       
        public string Department { get; set; }
   
        public DateTime DOB { get; set; }
       
        public string[] SelectedDepartments { get; set; } = Array.Empty<string>();
}
