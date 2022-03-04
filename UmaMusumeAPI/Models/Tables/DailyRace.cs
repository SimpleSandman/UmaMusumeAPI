using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class DailyRace
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public int Difficulty { get; set; }
        public int RaceInstanceId { get; set; }
        public int CostNum { get; set; }
        public int UniqueCharaNpcMin { get; set; }
        public int UniqueCharaNpcMax { get; set; }
        public int NormalRewardsOddsId { get; set; }
        public int BonusRewardsOddsId { get; set; }
        public int RareRewardOddsId { get; set; }
        public int FirstClearItemCategory1 { get; set; }
        public int FirstClearItemId1 { get; set; }
        public int FirstClearItemNum1 { get; set; }
        public int FirstClearItemCategory2 { get; set; }
        public int FirstClearItemId2 { get; set; }
        public int FirstClearItemNum2 { get; set; }
        public int FirstClearItemCategory3 { get; set; }
        public int FirstClearItemId3 { get; set; }
        public int FirstClearItemNum3 { get; set; }
        public int PickUpItemCategory1 { get; set; }
        public int PickUpItemId1 { get; set; }
        public int PickUpItemNum1 { get; set; }
        public int PickUpItemCategory2 { get; set; }
        public int PickUpItemId2 { get; set; }
        public int PickUpItemNum2 { get; set; }
        public int PickUpItemCategory3 { get; set; }
        public int PickUpItemId3 { get; set; }
        public int PickUpItemNum3 { get; set; }
        public int StartDate { get; set; }
        public int EndDate { get; set; }
    }
}
