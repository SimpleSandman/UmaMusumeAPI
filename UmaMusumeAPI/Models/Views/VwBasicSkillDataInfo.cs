﻿#nullable disable

namespace UmaMusumeAPI.Models.Views
{
    public partial class VwBasicSkillDataInfo
    {
        public int SkillDataId { get; set; }
        public long Rarity { get; set; }
        public long GroupId { get; set; }
        public long SkillCategory { get; set; }
        public string Condition1 { get; set; }
        public string Condition2 { get; set; }
        public string SkillName { get; set; }
        public string SkillDesc { get; set; }
    }
}