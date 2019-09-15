using System.Collections.Generic;
using RepositoryPatternsProject.dotnet.Models;

namespace RepositoryPatternsProject.dotnet.Infrastructure
{
    public interface IStudent
    {
        List<Student> GetAll();
        
    }
} 