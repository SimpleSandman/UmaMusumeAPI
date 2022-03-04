namespace UmaMusumeAPI.Models.Tables
{
    public class TransferEventReward
    {
        public int TransferRewardId { get; set; }
        public int TransferDetailId { get; set; }
        public int RewardRank { get; set; }
        public int ItemCategory { get; set; }
        public int ItemId { get; set; }
        public int ItemNum { get; set; }
        public int Odds { get; set; }
    }
}
