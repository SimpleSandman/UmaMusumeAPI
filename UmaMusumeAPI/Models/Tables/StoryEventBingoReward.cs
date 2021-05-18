﻿using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Tables
{
    public partial class StoryEventBingoReward
    {
        public int Id { get; set; }
        public long RewardSetId { get; set; }
        public long LineNum { get; set; }
        public long ItemCategory { get; set; }
        public long ItemId { get; set; }
        public long ItemNum { get; set; }
    }
}
