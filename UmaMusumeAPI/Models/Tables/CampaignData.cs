﻿using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Tables
{
    public partial class CampaignData
    {
        public int CampaignId { get; set; }
        public long TargetType { get; set; }
        public long TargetId { get; set; }
        public long EffectType1 { get; set; }
        public long EffectValue1 { get; set; }
        public long UserShow { get; set; }
        public long ImageIconId { get; set; }
        public long TransitionType { get; set; }
        public long ImageChange { get; set; }
        public long StartTime { get; set; }
        public long EndTime { get; set; }
    }
}
