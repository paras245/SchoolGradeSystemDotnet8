using Microsoft.EntityFrameworkCore;
using SchoolGradeSystem.Models;

namespace SchoolGradeSystem.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
        {
        }

        public DbSet<Students> Students { get; set; }
        public DbSet<Subjects> Subjects { get; set; }

    }
}
