using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class MainStoryRaceData
    {
        public int Id { get; set; }
        public int RaceInstanceId { get; set; }
        public int GroupId { get; set; }
        public int RaceConditionId { get; set; }
        public int ClearRank { get; set; }
        public int BonusGroupId { get; set; }
        public int BonusChara1 { get; set; }
        public int BonusChara2 { get; set; }
        public int BonusChara3 { get; set; }
        public int GimmickType { get; set; }
        public int GimmickTriggerSkill { get; set; }
        public int GimmickMatchRaceAsset { get; set; }
        public int GimmickUnmatchRaceAsset { get; set; }
    }
}
