using Microsoft.AspNetCore.Mvc;
using WebLast_MVC_.Models;
using WebLast_MVC_.Repositry;

namespace WebLast_MVC_.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourseRepositry _courseRepositry;
        private readonly ITeacherRepositry _teacherRepositry;

        public CourseController(ICourseRepositry courseRepositry, ITeacherRepositry teacherRepositry)
        {
            _courseRepositry = courseRepositry; 
            _teacherRepositry = teacherRepositry;
            
        }
        [HttpGet]
        public ActionResult Index()
        {
            List<Course> lista = _courseRepositry.GetAllCourse();
            return View(lista);
        }


        [HttpGet]
        public ActionResult Create()
        {
            List<Teacher> lista = _teacherRepositry.GetAllTeacher();
            return View(lista);
        }



        [HttpPost]
        public ActionResult Create(Course course)
        {
            _courseRepositry.Create(course);
            List<Course> lista = _courseRepositry.GetAllCourse();
            return View("Index",lista);
        }


        public ViewResult Delete(int id)
        {
            _courseRepositry.Delete(id);
            List<Course> lista = _courseRepositry.GetAllCourse();
            return View("Index", lista);
        }

    }
}
