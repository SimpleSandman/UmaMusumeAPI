namespace UmaMusumeAPI.Models.Tables
{
    public class DailyRace
    {
        public int Id { get; set; }
        public long GroupId { get; set; }
        public long Difficulty { get; set; }
        public long RaceInstanceId { get; set; }
        public long CostNum { get; set; }
        public long UniqueCharaNpcMin { get; set; }
        public long UniqueCharaNpcMax { get; set; }
        public long NormalRewardsOddsId { get; set; }
        public long RareRewardOddsId { get; set; }
        public long FirstClearItemCategory1 { get; set; }
        public long FirstClearItemId1 { get; set; }
        public long FirstClearItemNum1 { get; set; }
        public long FirstClearItemCategory2 { get; set; }
        public long FirstClearItemId2 { get; set; }
        public long FirstClearItemNum2 { get; set; }
        public long FirstClearItemCategory3 { get; set; }
        public long FirstClearItemId3 { get; set; }
        public long FirstClearItemNum3 { get; set; }
        public long PickUpItemCategory1 { get; set; }
        public long PickUpItemId1 { get; set; }
        public long PickUpItemNum1 { get; set; }
        public long PickUpItemCategory2 { get; set; }
        public long PickUpItemId2 { get; set; }
        public long PickUpItemNum2 { get; set; }
        public long PickUpItemCategory3 { get; set; }
        public long PickUpItemId3 { get; set; }
        public long PickUpItemNum3 { get; set; }
        public long StartDate { get; set; }
        public long EndDate { get; set; }
    }
}
