using WebLast_MVC_.Models;

namespace WebLast_MVC_.Repositry
{
    public class RoomRepositry : IRoomRepositry
    {
        private readonly ApplicationDbContext _context;

        public RoomRepositry(ApplicationDbContext applicationDb)
        {
            _context = applicationDb;   
            
        }


        public void Create(Room room)
        {
            _context.Rooms.Add(room);
            _context.SaveChanges(); 
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Room> GetAllRoom()
        {
            List<Room> lista=(from rr in  _context.Rooms
                              select rr).ToList();
            return lista;
        }
    }
}
