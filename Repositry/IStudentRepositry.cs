using WebLast_MVC_.Models;

namespace WebLast_MVC_.Repositry
{
    public interface IStudentRepositry
    {
        public List<Student> GetAllStudent();

        public void Create(Student student);

        public void Delete (int id);

        public void Register(int studentid,int courseid);
    }
}
