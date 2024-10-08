using WebLast_MVC_.Models;

namespace WebLast_MVC_.Repositry
{
    public interface IRoomRepositry
    {
        public List<Room> GetAllRoom();

        public void Create(Room room);

        public void Delete(int id);
    }
}
