namespace EventManagmentAPI.DTOs
{
    public class EventDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Speaker { get; set; }
        public DateTime DateTime { get; set; }
        public string Location { get; set; }
        public string Promoter { get; set; }
    }
}
