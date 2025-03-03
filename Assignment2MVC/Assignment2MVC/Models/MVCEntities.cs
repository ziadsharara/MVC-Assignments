using Microsoft.EntityFrameworkCore;

namespace Assignment2MVC.Models
{
    public class MVCEntities: DbContext
    {
        public DbSet<Department> Department { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<Trainee> Trainee { get; set; }
        public DbSet<Instructor> Instructor { get; set; }
        public DbSet<crsResult> crsResult { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.
                UseSqlServer("Data Source=.;Initial Catalog=MVC;Integrated Security=True;");
        }
    }
}
