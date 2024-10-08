using WebLast_MVC_.Models;

namespace WebLast_MVC_.Repositry
{
    public class StudentRepositry : IStudentRepositry
    {
        private readonly ApplicationDbContext _context;

        public StudentRepositry(ApplicationDbContext applicationDb)
        {
            _context = applicationDb;   
            
        }

        public void Create(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges(); 
        }

        public void Delete(int id)
        {
            Student s1=(from std in  _context.Students
                        where std.StudentID == id   
                        select std).FirstOrDefault();
            _context.Students.Remove(s1);   
            _context.SaveChanges();
        }

        public List<Student> GetAllStudent()
        {
            List<Student> lista=(from std in _context.Students
                                 select std).ToList();
            return lista;
            
        }

        public void Register(int studentid ,int cousreid)
        {
            StudentCourse s1=new StudentCourse();
            s1.StudentID = studentid;   
            s1.CourseID = cousreid;
            _context.studentCourses.Add(s1);
            _context.SaveChanges();

        }

       
    }
}
