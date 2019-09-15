using System.Collections.Generic;
using System.Linq;
using RepositoryPatternsProject.dotnet.Data;
using RepositoryPatternsProject.dotnet.Infrastructure;
using RepositoryPatternsProject.dotnet.Models;

namespace RepositoryPatternsProject.dotnet.Service
{
    public class StudentRepo : IStudent
    {
        private StudentContext _context;

        public StudentRepo(StudentContext context)
        {
            _context = context;
        }

        public List<Student> GetAll()
        {
            return _context.Students.ToList();
        }

        public Student GetById(int id)
        {
            return _context.Students.FirstOrDefault(x => x.Id == id);
        }

        public void Delete(Student student)
        {
            _context.Students.Remove(student);
        }

        public void Insert(Student student)
        {
            _context.Students.Add(student);
        }

        public void Update(Student student)
        {
            _context.Students.Update(student);
        }

        public void save()
        {
            _context.SaveChanges();
        }
    }
}