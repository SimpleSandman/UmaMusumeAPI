using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Tables
{
    public partial class SingleModeDifficultyData
    {
        public int DifficultyId { get; set; }
        public int Difficulty { get; set; }
        public long DifficultyRate { get; set; }
        public long ItemCategory { get; set; }
        public long ItemId { get; set; }
        public long MaxNum { get; set; }
    }
}
