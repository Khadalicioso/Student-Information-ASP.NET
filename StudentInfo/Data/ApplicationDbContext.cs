using Microsoft.EntityFrameworkCore;
using StudentInfo.Models.Entities;

namespace StudentInfo.Data
{
    public class ApplicationDbContext: DbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
    }
}
