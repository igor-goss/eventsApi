using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EventManagmentAPI.Models
{
    public class Event
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Speaker { get; set; }
        public DateTime? DateTime { get; set; }
        public string? Location { get; set; }
        public string? Promoter { get; set;}
    }
}
