using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class MapEventFlavorText
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public int ImageType { get; set; }
        public int StoryId { get; set; }
        public int StoryConditionType { get; set; }
    }
}
