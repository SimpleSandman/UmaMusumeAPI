﻿using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class TeamStadiumRawScore
    {
        public int Id { get; set; }
        public long Priority { get; set; }
        public long ConditionType { get; set; }
        public long ConditionValue1 { get; set; }
        public long ConditionValue2 { get; set; }
        public long Score { get; set; }
        public long RaceScoreNameId { get; set; }
        public long SortOrder { get; set; }
    }
}
