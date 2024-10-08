using Microsoft.AspNetCore.Mvc;
using WebLast_MVC_.Models;
using WebLast_MVC_.Repositry;

namespace WebLast_MVC_.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentRepositry _studentRepositry;
        private readonly ICourseRepositry _courseReposi;    
        public StudentController(IStudentRepositry stdtRepositry ,ICourseRepositry courseRepositry)
        {
            _studentRepositry = stdtRepositry;  
            _courseReposi = courseRepositry;
            
        }


        [HttpGet]
        public ActionResult Index()
        {
            List<Student> lista = _studentRepositry.GetAllStudent();
            return View(lista);
        }


            [HttpGet]
            public ActionResult Create()
            {
            
                return View();
            }



        [HttpPost]
        public ActionResult Create(Student student)
        {
            _studentRepositry.Create(student);
            List<Student> lista = _studentRepositry.GetAllStudent();
            return View("Index",lista);
        }


        public ViewResult Delete(int id)
        {
            _studentRepositry.Delete(id);
            List<Student> lista = _studentRepositry.GetAllStudent();
            return View("Index", lista);
        }


        [HttpGet]
        public ActionResult Register()
        {
            StudentCourseVM stdVM = new StudentCourseVM();
            stdVM.StudentVM = _studentRepositry.GetAllStudent();
            stdVM.CourseVM = _courseReposi.GetAllCourse();
            return View(stdVM);
        }



        [HttpPost]
        public ActionResult Register(int studentid ,int courseid)
        {
            _studentRepositry.Register(studentid, courseid);
            return View();
        }


    }
}
