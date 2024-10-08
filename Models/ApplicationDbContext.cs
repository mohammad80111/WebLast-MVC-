using Microsoft.EntityFrameworkCore;

namespace WebLast_MVC_.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) 
        {
            
        }

        //اسماء الجداول في قاعده البيانات
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentCourse> studentCourses { get; set; }

        public DbSet<Room> Rooms { get; set; }
    }
}
