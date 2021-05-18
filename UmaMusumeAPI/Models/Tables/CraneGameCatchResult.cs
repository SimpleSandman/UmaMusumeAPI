using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Tables
{
    public partial class CraneGameCatchResult
    {
        public int OddsId { get; set; }
        public int GetNum { get; set; }
        public long LotteryWeight11 { get; set; }
        public long LotteryWeight12 { get; set; }
        public long LotteryWeight21 { get; set; }
        public long LotteryWeight22 { get; set; }
        public long LotteryWeight31 { get; set; }
        public long LotteryWeight32 { get; set; }
        public long LotteryWeightExtra1 { get; set; }
        public long LotteryWeightExtra2 { get; set; }
    }
}
