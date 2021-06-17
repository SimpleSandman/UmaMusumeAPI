namespace UmaMusumeAPI.Models.Views
{
    public class BasicStoryEventMissionInfo
    {
        public int StoryEventMissionId { get; set; }
        public long StoryEventId { get; set; }
        public long MissionType { get; set; }
        public long StepGroupId { get; set; }
        public long ItemCategory { get; set; }
        public long ItemId { get; set; }
        public long ItemNum { get; set; }
        public string StoryEventMissionName { get; set; }
    }
}
