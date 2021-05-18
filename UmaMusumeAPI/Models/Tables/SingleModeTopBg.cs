using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Tables
{
    public partial class SingleModeTopBg
    {
        public int Id { get; set; }
        public long Month { get; set; }
        public long BgId { get; set; }
        public long BgSubId { get; set; }
    }
}
