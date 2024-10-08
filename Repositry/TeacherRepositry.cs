using WebLast_MVC_.Models;

namespace WebLast_MVC_.Repositry
{
    public class TeacherRepositry : ITeacherRepositry
    {
        private readonly ApplicationDbContext _context;
        public TeacherRepositry(ApplicationDbContext applicationDb)
        {
            _context = applicationDb;

        }
        public void Create(Teacher teacher)
        {
            _context.Teachers.Add(teacher);

            _context.SaveChanges(); 

        }

        public void Delete(int id)
        {
          Teacher t1=(from ter in _context.Teachers
                      where ter.TeacherId==id
                      select ter).FirstOrDefault();
            _context.Teachers.Remove(t1);
            _context.SaveChanges();


        }

        public List<Teacher> GetAllTeacher()
        {
            List<Teacher> lista=(from ter in  _context.Teachers
                           select ter).ToList();
            return lista;
           
        }
    }
}
