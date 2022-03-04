using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class ShortEpisode
    {
        public int Id { get; set; }
        public int Scene { get; set; }
        public int Sort { get; set; }
        public int ConditionType { get; set; }
        public int ConditionValue1 { get; set; }
        public int StoryId { get; set; }
    }
}
