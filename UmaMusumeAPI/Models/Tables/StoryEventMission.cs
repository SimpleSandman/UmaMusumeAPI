namespace UmaMusumeAPI.Models.Tables
{
    public partial class StoryEventMission
    {
        public int Id { get; set; }
        public long StoryEventId { get; set; }
        public long MissionType { get; set; }
        public long ConditionType { get; set; }
        public long ConditionValue1 { get; set; }
        public long ConditionValue2 { get; set; }
        public long ConditionValue3 { get; set; }
        public long ConditionValue4 { get; set; }
        public long ConditionNum { get; set; }
        public long StepGroupId { get; set; }
        public long StepOrder { get; set; }
        public long DispOrder { get; set; }
        public long ItemCategory { get; set; }
        public long ItemId { get; set; }
        public long ItemNum { get; set; }
        public long TransitionType { get; set; }
    }
}
