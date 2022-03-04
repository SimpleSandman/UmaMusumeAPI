using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class StoryEventMission
    {
        public int Id { get; set; }
        public int StoryEventId { get; set; }
        public int MissionType { get; set; }
        public int ConditionType { get; set; }
        public int ConditionValue1 { get; set; }
        public int ConditionValue2 { get; set; }
        public int ConditionValue3 { get; set; }
        public int ConditionValue4 { get; set; }
        public int ConditionNum { get; set; }
        public int StepGroupId { get; set; }
        public int StepOrder { get; set; }
        public int DispOrder { get; set; }
        public int ItemCategory { get; set; }
        public int ItemId { get; set; }
        public int ItemNum { get; set; }
        public int TransitionType { get; set; }
        public int DateCheckFlg { get; set; }
        public int StartDate { get; set; }
    }
}
