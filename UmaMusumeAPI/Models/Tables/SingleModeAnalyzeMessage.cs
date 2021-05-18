using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Tables
{
    public partial class SingleModeAnalyzeMessage
    {
        public int Id { get; set; }
        public long ProperGround { get; set; }
        public long ProperDistance { get; set; }
        public long Popularity { get; set; }
        public long Year { get; set; }
        public long Priority { get; set; }
        public long Rate { get; set; }
        public long MotionType { get; set; }
        public long CharacterType { get; set; }
    }
}
