using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace NewDB.Models
{
    [Table("studenttable", Schema = "public")]
    public class StudentInfo
    {
        [Key]
        [Column("id")]
        public int ID { get; set; }
        [Column("mobile")]
        public long Mobile { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("mailid")]
        public string MailID { get; set; }
        [Column("photo")]
        public byte[] Photo { get; set; }
        [Column("department")]
        public string Department { get; set; }
        // public string Comment { get; set; }
    }
}