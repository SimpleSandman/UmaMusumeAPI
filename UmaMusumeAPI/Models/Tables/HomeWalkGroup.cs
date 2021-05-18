using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Tables
{
    public partial class HomeWalkGroup
    {
        public int Id { get; set; }
        public long CharaId1 { get; set; }
        public long CharaId2 { get; set; }
        public long CharaId3 { get; set; }
    }
}
