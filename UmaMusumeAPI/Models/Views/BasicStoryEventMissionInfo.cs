namespace UmaMusumeAPI.Models.Views
{
    public class BasicStoryEventMissionInfo
    {
        public int StoryEventMissionId { get; set; }
        public int StoryEventId { get; set; }
        public int MissionType { get; set; }
        public int StepGroupId { get; set; }
        public int ItemCategory { get; set; }
        public int ItemId { get; set; }
        public int ItemNum { get; set; }
        public string StoryEventMissionName { get; set; }
        public string StoryEventMissionNameEnglish { get; set; }
    }
}
