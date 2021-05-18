using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Tables
{
    public partial class CharaMotionAct
    {
        public int Id { get; set; }
        public long CharaId { get; set; }
        public long TargetMotion { get; set; }
        public string CommandName { get; set; }
    }
}
