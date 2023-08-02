using EventManagmentAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class EventDbContext : DbContext
    {
        public EventDbContext(DbContextOptions<EventDbContext> options) : base(options)
        {
        }

        public DbSet<Event> Events { get; set; }
    }

}