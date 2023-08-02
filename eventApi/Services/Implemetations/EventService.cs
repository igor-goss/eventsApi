using EventManagmentAPI.DataAccess;
using EventManagmentAPI.Models;
using EventManagmentAPI.Services.Interfaces;

namespace EventManagmentAPI.Services.Implemetations
{
    public class EventService : IEventService
    {
        private readonly IEventRepository _eventRepository;

        public EventService(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }
        
        public IEnumerable<Event> GetAllEvents()
        {
            return _eventRepository.GetAllEvents();
        }

        public Event GetEventById(int id)
        {
            return _eventRepository.GetEventById(id);
        }

        public void CreateEvent(Event @event)
        {
            _eventRepository.CreateEvent(@event);
        }

        public void UpdateEvent(int id, Event @event) //the
        {
            @event.Id = id;
            _eventRepository.UpdateEvent(@event);
        }

        public void DeleteEvent(int id)
        {
            _eventRepository.DeleteEvent(id);
        }
    }
}
