using Microsoft.EntityFrameworkCore;

namespace ASP_Core_Empty.Models
{
    public class StudentDBContext : DbContext // DbContext is the parent class which interact with the Databases and is used to implement Code-first approch...
    {
        public StudentDBContext(DbContextOptions options) : base(options) // base method is used to call the constructor of parent class that is DbContext class... 
        {
            
        }
        public DbSet<Student> Students { get; set; } // this will represent the table inside the database means "Students" named table...
    }
}
