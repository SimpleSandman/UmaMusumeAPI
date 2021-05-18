using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Tables
{
    public partial class LegendRaceNpc
    {
        public int Id { get; set; }
        public long NpcGroupId { get; set; }
        public long CharaId { get; set; }
        public long MobId { get; set; }
        public long RaceDressId { get; set; }
        public long RaceInstanceId { get; set; }
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
