using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Tables
{
    public partial class LimitedExchangeRewardOdd
    {
        public int Id { get; set; }
        public long OddsId { get; set; }
        public long GroupId { get; set; }
        public long DispOrder { get; set; }
        public long Odds { get; set; }
    }
}
