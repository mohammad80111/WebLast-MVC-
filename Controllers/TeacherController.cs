using Microsoft.AspNetCore.Mvc;
using WebLast_MVC_.Models;
using WebLast_MVC_.Repositry;

namespace WebLast_MVC_.Controllers
{
    public class TeacherController : Controller
    {
        private readonly ITeacherRepositry _teacherRepositry;

            
        public TeacherController(ITeacherRepositry teacherRepositry)
        {
            _teacherRepositry = teacherRepositry;
        }


        [HttpGet]
        public ActionResult Index()
        {
            List<Teacher> lista=_teacherRepositry.GetAllTeacher();
            return View(lista);
        }


        [HttpGet]
        public ActionResult Create()
        {

            return View();
        }



        [HttpPost]
        public ActionResult Create(Teacher teacher)
        {
            _teacherRepositry.Create(teacher);
            List<Teacher> lista = _teacherRepositry.GetAllTeacher();
            return View("Index",lista);
        }


        public ViewResult Delete(int id)
        {
            _teacherRepositry.Delete(id);
            List<Teacher> lista = _teacherRepositry.GetAllTeacher();
            return View("Index", lista);
        }

    }
}
