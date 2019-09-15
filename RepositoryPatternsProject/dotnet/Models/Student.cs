using System;
using System.Net.Cache;

namespace RepositoryPatternsProject.dotnet.Models
{
    public class Student
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleInitial { get; set; }
        public bool IsFailing { get; set; }
    }
}