using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Tables
{
    public partial class ChampionsEvaluationRate
    {
        public int Id { get; set; }
        public long ProperType { get; set; }
        public long ProperRank { get; set; }
        public long Rate { get; set; }
    }
}
