using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewDB.Models
{
    public class StudentsService
    {
        protected readonly ApplicationDBContext _DbContext;
        public StudentsService(ApplicationDBContext _db)
        {
            _DbContext = _db;
        }
        // public List<StudentInfo> GetAllStudent()
        // {
        //     return _DbContext.studenttable.ToList();
        // }
        public List<StudentInfo> GetAllStudent()
        {
            return _DbContext.studenttable.OrderBy(s => s.ID).ToList();
        }

        public bool InsertRec(StudentInfo studentInfo)
        {
            _DbContext.studenttable.Add(studentInfo);
            _DbContext.SaveChanges();
            return true;
        }
        public void EditRec(int stdid)
        {
            StudentInfo studentInfo = new StudentInfo();
            _DbContext.studenttable.FirstOrDefault(u => u.ID.Equals(stdid));
        }
//    public bool UpdateRec(StudentInfo studentInfo)
// {
//     _DbContext.SaveChanges(); // already tracked entity
//     return true;
// }


        public bool UpdateRec(StudentInfo studentInfo)
        {
            var Stdupdate = _DbContext.studenttable.FirstOrDefault(u => u.ID.Equals(studentInfo.ID));
            if (Stdupdate != null)
            {
                Console.WriteLine($"Updating student ID: {studentInfo.ID}");
                Stdupdate.Name = studentInfo.Name;
                Stdupdate.Mobile = studentInfo.Mobile;
                Stdupdate.MailID = studentInfo.MailID;
                Stdupdate.Photo = studentInfo.Photo;
                Stdupdate.Department = studentInfo.Department;
                _DbContext.SaveChanges();
            }
            else
            {
                Console.WriteLine($"Student with ID {studentInfo.ID} not found");
                return false;
            }
            return true;
        }
        public bool DeleteRec(StudentInfo studentInfo)
        {
            var Stdupdate = _DbContext.studenttable.FirstOrDefault(u => u.ID.Equals(studentInfo.ID));
            if (Stdupdate != null)
            {
                _DbContext.Remove(Stdupdate);
                _DbContext.SaveChanges();
            }
            else
            {
                return false;
            }
            return true;
        }
    }
}