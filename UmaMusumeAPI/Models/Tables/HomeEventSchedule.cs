using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class HomeEventSchedule
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public int StartDate { get; set; }
        public int EndDate { get; set; }
        public int EventStoryType { get; set; }
        public int EventWalkType { get; set; }
        public int EventFooterType { get; set; }
        public int EventFooterPropId { get; set; }
        public int EventWalkPropId { get; set; }
    }
}
