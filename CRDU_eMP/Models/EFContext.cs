using Microsoft.EntityFrameworkCore;

namespace CRDU_eMP.Models
{
    public class EFContext : DbContext
    {
        public EFContext(DbContextOptions<EFContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server= SHALABY\\SQL2019 ;Database=MVC2 ;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        // DbSet properties for your entities (Employee, Office, Project, EmpProject)

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Office> Offices { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<EmpProject> EmpProjects { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmpProject>()
                .HasKey(ep => new { ep.EmpId, ep.ProjId });
        }




    }
}
