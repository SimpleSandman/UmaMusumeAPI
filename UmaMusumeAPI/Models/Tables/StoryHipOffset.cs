using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Tables
{
    public partial class StoryHipOffset
    {
        public long CategoryId { get; set; }
        public long CharaId { get; set; }
        public long Offset { get; set; }
    }
}
