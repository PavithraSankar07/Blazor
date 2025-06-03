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
        public bool Add(StudentInfo studentInfo)
        {
            _DbContext.studenttable.Add(studentInfo);
            _DbContext.SaveChanges();
            return true;
        }
        // public void EditRec(int stdid)
        // {
        //     StudentInfo studentInfo = new StudentInfo();
        //     _DbContext.studenttable.FirstOrDefault(u => u.ID.Equals(stdid));
        // }
        public void EditRec(StudentInfo updatedInfo)
        {
            // StudentInfo studentInfo = _DbContext.studenttable.Find(u => u.ID.Equals(updatedInfo.ID));
            // if (!studentInfo.Equals(null))
            // {

            //     _DbContext.SaveChanges();
            // }
            _DbContext.studenttable.Update(updatedInfo);
            _DbContext.SaveChanges();
        }
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
                Stdupdate.Time = studentInfo.Time;
                Stdupdate.DateTime = studentInfo.DateTime;
                Stdupdate.Languages = studentInfo.Languages;
                Stdupdate.Amount = studentInfo.Amount;
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