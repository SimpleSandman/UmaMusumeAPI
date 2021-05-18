using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Tables
{
    public partial class SkillExp
    {
        public int Id { get; set; }
        public long Type { get; set; }
        public long Level { get; set; }
        public long Scale { get; set; }
    }
}
