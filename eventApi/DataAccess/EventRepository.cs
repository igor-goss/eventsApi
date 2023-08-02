using DataAccess;
using EventManagmentAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EventManagmentAPI.DataAccess
{
    public class EventRepository : IEventRepository
    {
        private readonly EventDbContext _dbContext;

        public EventRepository(EventDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Event> GetAllEvents()
        {
            return _dbContext.Events.ToList();
        }

        public Event GetEventById(int id)
        {
            return _dbContext.Events.FirstOrDefault(e => e.Id == id);
        }

        public void CreateEvent(Event @event)
        {
            _dbContext.Events.Add(@event);
            _dbContext.SaveChanges();
        }

        public void UpdateEvent(Event @event) //hell
        {
            _dbContext.Events.Update(@event);
            _dbContext.SaveChanges();
        }

        public void DeleteEvent(int id)
        {
            _dbContext.Events.Where(e => e.Id == id).ExecuteDelete();
        }
    }
}
