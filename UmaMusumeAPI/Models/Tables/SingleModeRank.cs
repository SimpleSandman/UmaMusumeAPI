using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Tables
{
    public partial class SingleModeRank
    {
        public int Id { get; set; }
        public long MinValue { get; set; }
        public long MaxValue { get; set; }
    }
}
