using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Tables
{
    public partial class TrainedCharaTradeItem
    {
        public int Id { get; set; }
        public long TrainedCharaRank { get; set; }
        public long TradeItemCategory { get; set; }
        public long TradeItemId { get; set; }
        public long TradeItemNum { get; set; }
    }
}
