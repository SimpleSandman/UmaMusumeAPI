using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Tables
{
    public partial class HomePropSetting
    {
        public int PosId { get; set; }
        public int Personality { get; set; }
        public long PropId { get; set; }
        public long AttachNode { get; set; }
    }
}
