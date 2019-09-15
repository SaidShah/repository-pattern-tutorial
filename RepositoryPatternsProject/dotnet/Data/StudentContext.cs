using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using RepositoryPatternsProject.dotnet.Models;

namespace RepositoryPatternsProject.dotnet.Data
{
    public class StudentContext : DbContext
    {

        public StudentContext(DbContextOptions<StudentContext> options) : base(options)
        {
            
        }

        public DbSet<Student> Students { get; set; }
        
        

    }
}