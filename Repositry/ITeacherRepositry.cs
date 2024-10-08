using WebLast_MVC_.Models;

namespace WebLast_MVC_.Repositry
{
    public interface ITeacherRepositry
    {

        public List<Teacher> GetAllTeacher();

        public void Create(Teacher teacher);

        public void Delete(int id);
    }
}
