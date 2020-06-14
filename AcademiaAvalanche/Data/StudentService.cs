using System.Collections.Generic;
using System.Linq;

namespace AcademiaAvalanche.Data
{
    public class StudentService
    {
        private readonly ApplicationDbContext _db;

        public StudentService(ApplicationDbContext db)
        {
            _db = db;
        }

        public List<StudentInfo> GetStudent()
        {
            var studentList = _db.Students.ToList();
            return studentList;
        }

        public List<StudentInfo> GetStudentWithPendings()
        {
            var studentWithPendingsList = _db.Students.Where(x => x.Status == "Inadiplente").ToList();
            return studentWithPendingsList;
        }

        public string Create(StudentInfo objStudent)
        {
            _db.Students.Add(objStudent);
            _db.SaveChanges();
            return "Save Successfully";
        }

        public StudentInfo GetStudentById(int id)
        {
            StudentInfo student = _db.Students.SingleOrDefault(x => x.StudentId == id);
            return student;
        }

        public string UpdateStudent(StudentInfo objStudent)
        {
            _db.Students.Update(objStudent);
            _db.SaveChanges();
            return "Update Successfully";
        }

        public string DeleteStudentInfo(StudentInfo objStudent)
        {
            _db.Remove(objStudent);
            _db.SaveChanges();
            return "Delete Successfully";
        }
    }
}
