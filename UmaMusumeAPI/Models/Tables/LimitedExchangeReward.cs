namespace UmaMusumeAPI.Models.Tables
{
    public partial class LimitedExchangeReward
    {
        public int Id { get; set; }
        public long GroupId { get; set; }
        public long Odds { get; set; }
        public long ItemExchangeId { get; set; }
        public long RibbonValue { get; set; }
    }
}
