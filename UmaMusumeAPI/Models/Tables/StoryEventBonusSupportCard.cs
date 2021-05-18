using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Tables
{
    public partial class StoryEventBonusSupportCard
    {
        public int Id { get; set; }
        public long StoryEventId { get; set; }
        public long CharaId { get; set; }
        public long Rarity { get; set; }
        public long SupportCardId { get; set; }
        public long Limit0 { get; set; }
        public long Limit1 { get; set; }
        public long Limit2 { get; set; }
        public long Limit3 { get; set; }
        public long Limit4 { get; set; }
        public long StartDate { get; set; }
        public long EndDate { get; set; }
    }
}
