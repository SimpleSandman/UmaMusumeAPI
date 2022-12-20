using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class CollectRaidMaster
    {
        public int Id { get; set; }
        public int CollectItemId { get; set; }
        public int GainCollectItemRate { get; set; }
        public int GainCollectItemMin { get; set; }
        public int IndividualRewardSetId { get; set; }
        public int AllRewardSetId { get; set; }
        public int StorySetId { get; set; }
        public int MissionTopCharaGroupId { get; set; }
        public int StagingMiniCharaGroupId { get; set; }
        public int StoryListBgId { get; set; }
        public int StoryListBgSubId { get; set; }
        public int CollectEventMapMasterId { get; set; }
        public int NoticeDate { get; set; }
        public int StartDate { get; set; }
        public int CalcStartDate { get; set; }
        public int CalcEndDate { get; set; }
        public int EndDate { get; set; }
    }
}
