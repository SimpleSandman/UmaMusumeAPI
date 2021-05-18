using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Tables
{
    public partial class SkillLevelValue
    {
        public int Id { get; set; }
        public long AbilityType { get; set; }
        public long Level { get; set; }
        public long FloatAbilityValueCoef { get; set; }
    }
}
