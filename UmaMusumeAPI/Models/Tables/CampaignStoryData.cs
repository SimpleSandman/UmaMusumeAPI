using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class CampaignStoryData
    {
        public int Id { get; set; }
        public int CampaignId { get; set; }
        public int ConditionType { get; set; }
        public int ConditionValue { get; set; }
        public int StoryId { get; set; }
    }
}
