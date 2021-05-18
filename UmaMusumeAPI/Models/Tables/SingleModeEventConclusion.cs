using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Tables
{
    public partial class SingleModeEventConclusion
    {
        public int Id { get; set; }
        public int CharaId { get; set; }
        public long CharaMotionSetId { get; set; }
    }
}
