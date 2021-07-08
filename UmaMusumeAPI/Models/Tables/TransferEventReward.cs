namespace UmaMusumeAPI.Models.Tables
{
    public class TransferEventReward
    {
        public int TransferRewardId { get; set; }
        public long TransferDetailId { get; set; }
        public long RewardRank { get; set; }
        public long ItemCategory { get; set; }
        public long ItemId { get; set; }
        public long ItemNum { get; set; }
        public long Odds { get; set; }
    }
}
