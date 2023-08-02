using Microsoft.AspNetCore.Mvc;
using EventManagmentAPI.Models;
using EventManagmentAPI.Services.Interfaces;
using AutoMapper;
using EventManagmentAPI.DTOs;
using Microsoft.AspNetCore.Authorization;
using System.Net;

namespace EventManagmentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class EventController : ControllerBase
    {
        private readonly IEventService _eventService;
        private readonly IMapper _mapper;

        public EventController(IEventService eventService, IMapper mapper)
        {
            _eventService = eventService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllEvents()
        {
            var events = _eventService.GetAllEvents();
            return Ok(events);
        }

        [HttpGet("{id}")]
        public IActionResult GetEventById(int id) 
        {
            var @event = _eventService.GetEventById(id);
            if (@event == null)
            {
                return NotFound();
            }
            return Ok(@event);
        }

        [HttpPost]
        public IActionResult CreateEvent([FromBody] EventDto eventDto) 
        {
            _eventService.CreateEvent(_mapper.Map<Event>(eventDto));

            return CreatedAtAction(nameof(GetEventById), new { id = eventDto.Id }, eventDto);

        }

        [HttpPut("{id}")]
        public IActionResult UpdateEvent(int id, [FromBody] EventDto eventDto) //what
        {
            _eventService.UpdateEvent(id, _mapper.Map<Event>(eventDto));

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteEvent(int id)
        {
            _eventService.DeleteEvent(id);
            return Ok();
        }
    
    }
}
