﻿namespace UmaMusumeAPI.Models.Tables
{
    public partial class MainStoryRaceBonusCondition
    {
        public int Id { get; set; }
        public long GroupId { get; set; }
        public long ConditionType { get; set; }
        public long ConditionValue1 { get; set; }
        public long ConditionValue2 { get; set; }
    }
}