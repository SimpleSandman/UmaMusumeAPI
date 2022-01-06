using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class TrainedCharaTradeItem
    {
        public int Id { get; set; }
        public long TrainedCharaRank { get; set; }
        public long TradeItemCategory { get; set; }
        public long TradeItemId { get; set; }
        public long TradeItemNum { get; set; }
    }
}
