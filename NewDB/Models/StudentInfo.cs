using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
    [Column("degree")]
    public string Degree { get; set; }
    [Column("department")]
    public string Department { get; set; }
    [Column("dob")]
    public DateTime DOB { get; set; } = System.DateTime.Today;
    [Column("selecteddepartments")]
    public string[] SelectedDepartments { get; set; } = Array.Empty<string>();

    [Column("time")]
    public string? Time { get; set; }
    [Column("datetime")]
    public DateTime DateTime { get; set; } = System.DateTime.Today;
    [Column("languages")]
    public List<string>? Languages { get; set; } = new();

    [Column("amount")]
    public Double? Amount { get; set; }


    // public enum GenderEnum
    // {
    //   Male=0,
    //   Female=1,
    //   Other=2
    // }
    // [Column("gender")]
    // public GenderEnum? Gender { get; set; }

  }
}