using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.Models;
using System.Linq;
using WinFormsApp1.Data;

namespace SchoolManagementSystem.Services
{
    public class ProfessorService
    {
        private AppDbContext _db;
        public ProfessorService(AppDbContext db)
        {
            _db = db;
        }
        public bool Add(Professor member)
        {
            if (member is null) { return false; }
            _db.professors.Add(member);
            _db.SaveChanges();
            return true;
        }
        public bool Add(List<Professor> Professors)
        {
            if (Professors is null) { return false; }
            _db.professors.AddRange(Professors);
            _db.SaveChanges();
            return true;
        }
        public bool Remove(Professor member)
        {
            if (member is null) { return false; }
            _db.professors.Remove(member);
            var classesAssigned = _db.professorClasses.Where(c => c.profId == member.id).ToList();
            _db.professorClasses.RemoveRange(classesAssigned);
            _db.SaveChanges();
            return true;
        }
        public bool Remove(string firstName, string lastName)
        {
            var member = _db.professors.FirstOrDefault(x => x.firstName == firstName && x.lastName == lastName);
            if (member is null) return false;
            _db.professors.Remove(member);
            var classesAssigned = _db.professorClasses.Where(c => c.profId == member.id).ToList();
            _db.professorClasses.RemoveRange(classesAssigned);
            _db.SaveChanges();
            return true;
        }
        public List<Professor> GetBy(Filter filter)
        {
            var Result = _db.professors.ToList();
            if (filter.firstName is not null)
            {
                var subResult = _db.professors.Where(x => x.firstName.Contains(filter.firstName)).ToList();
                Result = Result.Intersect(subResult).ToList();
            }
            if (filter.lastName is not null)
            {
                var subResult = _db.professors.Where(x => x.lastName.Contains(filter.lastName)).ToList();
                Result = Result.Intersect(subResult).ToList();
            }
            return Result;
        }
        public List<Professor> GetAll()
        {
            var Professors = _db.professors.ToList();
            return Professors;
        }
        public void RemoveAll()
        {
            _db.Database.ExecuteSqlRaw("TRUNCATE TABLE [professors]");
            _db.Database.ExecuteSqlRaw("TRUNCATE TABLE [professorClasses]");
        }
        public bool AssignToClass(Professor member, string classCode)
        {
            bool memberResult = _db.professors.Contains(member);
            bool codeResult = _db.classes.FirstOrDefault(x => x.code == classCode) is not null;

            if (!memberResult || !codeResult)
                return false;

            var assignment = new ProfessorClass()
            {
                profId = member.id,
                classCode = classCode
            };
            _db.professorClasses.Add(assignment);
            return true;
        }
        public List<Professor> AllClassProfessors(string classCode)
        {
            var _class = _db.classes.FirstOrDefault(x => x.code == classCode);
            if (_class is null)
                return new List<Professor>();
            var Ids = _db.professorClasses.Where(x => x.classCode == classCode).ToList();
            var professors = new List<Professor>();
            foreach (var id in Ids)
            {
                professors.Add(_db.professors.First(x => x.id == id.profId));
            }
            return professors;
        }
    }
}
