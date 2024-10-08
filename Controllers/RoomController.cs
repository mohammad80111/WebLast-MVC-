using Microsoft.AspNetCore.Mvc;
using WebLast_MVC_.Models;
using WebLast_MVC_.Repositry;

namespace WebLast_MVC_.Controllers
{
    public class RoomController : Controller
    {

        private readonly IRoomRepositry _roomRepositry;

        public RoomController(IRoomRepositry roomRepositry)
        {
            _roomRepositry = roomRepositry; 
            
        }


        [HttpGet]
        public ActionResult Index()
        {
            List<Room> lista = _roomRepositry.GetAllRoom();
            return View(lista);
        }


        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }



        [HttpPost]
        public ActionResult Create(Room room)
        {
            _roomRepositry.Create(room);
            List<Room> lista = _roomRepositry.GetAllRoom();
            return View("Index",lista);
        }


        public ViewResult Delete(int id)
        {
            _roomRepositry.Delete(id);
            List<Room> lista = _roomRepositry.GetAllRoom();
            return View("Index",lista);
        }

    }
}
