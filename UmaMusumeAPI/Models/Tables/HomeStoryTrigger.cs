﻿using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Tables
{
    public partial class HomeStoryTrigger
    {
        public int Id { get; set; }
        public long PosId { get; set; }
        public long HomeEventType { get; set; }
        public long Num { get; set; }
        public long StoryId { get; set; }
        public long CharaId1 { get; set; }
        public long CharaId2 { get; set; }
        public long CharaId3 { get; set; }
        public long ConditionType { get; set; }
    }
}
