using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Tables
{
    public partial class SuccessionRelationRank
    {
        public int RelationRank { get; set; }
        public long RankValueMin { get; set; }
        public long RankValueMax { get; set; }
    }
}
