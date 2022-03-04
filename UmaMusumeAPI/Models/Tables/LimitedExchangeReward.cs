using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class LimitedExchangeReward
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public int Odds { get; set; }
        public int ItemExchangeId { get; set; }
        public int RibbonValue { get; set; }
    }
}
