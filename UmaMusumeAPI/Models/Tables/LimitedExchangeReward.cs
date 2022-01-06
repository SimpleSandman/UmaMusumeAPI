using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class LimitedExchangeReward
    {
        public int Id { get; set; }
        public long GroupId { get; set; }
        public long Odds { get; set; }
        public long ItemExchangeId { get; set; }
        public long RibbonValue { get; set; }
    }
}
