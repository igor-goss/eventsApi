using EventManagmentAPI.Models;

namespace EventManagmentAPI.DataAccess
{
    public interface IEventRepository
    {
        IEnumerable<Event> GetAllEvents();
        Event GetEventById(int id);
        void CreateEvent(Event @event);
        void UpdateEvent(Event @event);
        void DeleteEvent(int id);
    }
}
