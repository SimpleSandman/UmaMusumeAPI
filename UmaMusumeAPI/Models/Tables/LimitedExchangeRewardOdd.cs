using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class LimitedExchangeRewardOdd
    {
        public int Id { get; set; }
        public int OddsId { get; set; }
        public int GroupId { get; set; }
        public int DispOrder { get; set; }
        public int Odds { get; set; }
    }
}
