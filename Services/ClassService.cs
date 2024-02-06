using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Data;

namespace SchoolManagementSystem.Services
{
    public class ClassService
    {
        private AppDbContext _db;
        public ClassService(AppDbContext db)
        {
            _db = db;
        }
        public bool Add(Class _class)
        {
            bool exist = _db.classes.FirstOrDefault(x => x.code == _class.code) is not null;
            if (_class is null || exist) return false;
            _db.classes.Add(_class);
            _db.SaveChanges();
            return true;
        }
        public bool Remove(Class _class)
        {
            if (_class is null) return false;
            _db.classes.Remove(_class);
            var assignedStudents = _db.StudentClasses.Where(x => x.classCode == _class.code).ToList();
            var assignedProfessors = _db.professorClasses.Where(x => x.classCode == _class.code).ToList();
            _db.StudentClasses.RemoveRange(assignedStudents);
            _db.professorClasses.RemoveRange(assignedProfessors);
            _db.SaveChanges();
            return true;
        }
        public List<Class> GetAll()
        {
            return _db.classes.ToList();
        }
        public void RemoveAll()
        {
            _db.Database.ExecuteSqlRaw("TRUNCATE TABLE [classes]");
        }
        public List<Class> GetStudentClasses(Student student)
        {
            bool notFound = !_db.Students.Contains(student);
            if (student is null || notFound) return new List<Class>();
            var classesCodes = _db.StudentClasses.Where(x => x.studentId ==  student.id).ToList();
            var codes = new HashSet<string>();
            foreach( var classesCode in classesCodes)
            {
                codes.Add(classesCode.classCode);
            }
            var classes = new List<Class>();    
            foreach(var code in codes)
            {
                classes.Add(_db.classes.First(x => x.code == code));
            }
            return classes;
        }
        public List<Class> GetProfClasses(Professor professor)
        {
            bool notFound = !_db.professors.Contains(professor);
            if (professor is null || notFound) return new List<Class>();
            var classesCodes = _db.professorClasses.Where(x => x.profId == professor.id).ToList();
            var codes = new HashSet<string>();
            foreach (var classesCode in classesCodes)
            {
                codes.Add(classesCode.classCode);
            }
            var classes = new List<Class>();
            foreach (var code in codes)
            {
                classes.Add(_db.classes.First(x => x.code == code));
            }
            return classes;
        }
    }
}
