using Microsoft.EntityFrameworkCore;

namespace AcademiaAvalanche.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<StudentInfo> Students { get; set; }
        public DbSet<TrainerInfo> Trainers { get; set; }
    }
}
