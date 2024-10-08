using WebLast_MVC_.Models;

namespace WebLast_MVC_.Repositry
{
    public interface ICourseRepositry

    {

        public List<Course> GetAllCourse();

        public void Create(Course course);

        public void Delete(int id);
    }
}
