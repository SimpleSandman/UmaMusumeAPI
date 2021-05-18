using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Tables
{
    public partial class TeamStadiumStandMotion
    {
        public long CharacterId { get; set; }
        public long Type { get; set; }
        public long RaceDressId { get; set; }
        public long Position { get; set; }
        public long MotionSet { get; set; }
        public long Rotation { get; set; }
        public long PositionX { get; set; }
    }
}
