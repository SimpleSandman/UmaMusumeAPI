using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Tables
{
    public partial class SingleModeMessage
    {
        public int Id { get; set; }
        public long Priority { get; set; }
        public long Emergent { get; set; }
        public long StatusType1 { get; set; }
        public long StatusValue11 { get; set; }
        public long StatusValue12 { get; set; }
        public long StatusType2 { get; set; }
        public long StatusValue21 { get; set; }
        public long StatusValue22 { get; set; }
        public long CharacterType { get; set; }
    }
}
