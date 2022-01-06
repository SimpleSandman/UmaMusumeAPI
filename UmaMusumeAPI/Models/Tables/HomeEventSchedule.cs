using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class HomeEventSchedule
    {
        public int Id { get; set; }
        public long EventId { get; set; }
        public long StartDate { get; set; }
        public long EndDate { get; set; }
    }
}
