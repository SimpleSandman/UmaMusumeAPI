using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Tables
{
    public partial class ChampionsStandMotion
    {
        public int CharaId { get; set; }
        public int Type { get; set; }
        public long RaceDressId { get; set; }
        public long MotionSet { get; set; }
    }
}
