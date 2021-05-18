using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Tables
{
    public partial class SingleModeSkillNeedPoint
    {
        public int Id { get; set; }
        public long NeedSkillPoint { get; set; }
        public long StatusType { get; set; }
        public long StatusValue { get; set; }
    }
}
