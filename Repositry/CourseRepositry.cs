using WebLast_MVC_.Models;

namespace WebLast_MVC_.Repositry
{
    public class CourseRepositry : ICourseRepositry
    {
        private readonly ApplicationDbContext _context;

        public CourseRepositry(ApplicationDbContext applicationDb)
        {
            _context = applicationDb;   
            
        }
        public void Create(Course course)
        {
            _context.Courses.Add(course);   
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            Course c1=(from cou in _context.Courses
                       where cou.CourseID==id
                       select cou).FirstOrDefault();
            _context.Courses.Remove(c1);    
            _context.SaveChanges(); 
        }

        public List<Course> GetAllCourse()
        {
            List<Course> lista=(from  cou in _context.Courses select cou).ToList();
            return lista;
        }
    }
}
