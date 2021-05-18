using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Tables
{
    public partial class ChampionsEntryReward
    {
        public int ChampionsId { get; set; }
        public long ItemCategory { get; set; }
        public int ItemId { get; set; }
        public long ItemNum { get; set; }
    }
}
