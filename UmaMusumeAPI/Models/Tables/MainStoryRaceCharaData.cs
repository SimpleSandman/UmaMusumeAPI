using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Tables
{
    public partial class MainStoryRaceCharaData
    {
        public int Id { get; set; }
        public long GroupId { get; set; }
        public long BracketNumber { get; set; }
        public long CharaId { get; set; }
        public long MobId { get; set; }
        public long DressId { get; set; }
        public long Motivation { get; set; }
        public long RunningStyle { get; set; }
        public long Speed { get; set; }
        public long Stamina { get; set; }
        public long Pow { get; set; }
        public long Guts { get; set; }
        public long Wiz { get; set; }
        public long ProperDistanceShort { get; set; }
        public long ProperDistanceMile { get; set; }
        public long ProperDistanceMiddle { get; set; }
        public long ProperDistanceLong { get; set; }
        public long ProperRunningStyleNige { get; set; }
        public long ProperRunningStyleSenko { get; set; }
        public long ProperRunningStyleSashi { get; set; }
        public long ProperRunningStyleOikomi { get; set; }
        public long ProperGroundTurf { get; set; }
        public long ProperGroundDirt { get; set; }
        public long SkillSetId { get; set; }
    }
}
