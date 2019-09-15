using System.Collections.Generic;
using RepositoryPatternsProject.dotnet.Models;

namespace RepositoryPatternsProject.dotnet.Infrastructure
{
    public interface IStudent
    {
        List<Student> GetAll();
        Student GetById(int id);

        void Delete(Student student);

        void Insert(Student student);

        void Update(Student student);

        void save();


    }
} 