using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Tables
{
    public partial class LoveRank
    {
        public int Id { get; set; }
        public long Rank { get; set; }
        public long TotalPoint { get; set; }
    }
}
