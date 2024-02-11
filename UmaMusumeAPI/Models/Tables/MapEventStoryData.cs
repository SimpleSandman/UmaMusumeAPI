using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class MapEventStoryData
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public int EpisodeIndexId { get; set; }
        public int StoryConditionType { get; set; }
        public int StoryId { get; set; }
        public int PointConditionType { get; set; }
        public int StartDate { get; set; }
    }
}
