using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Tables
{
    public partial class AnnounceEvent
    {
        public int Id { get; set; }
        public string CueName { get; set; }
        public string CueSheetName { get; set; }
        public long VoiceTextAsset { get; set; }
        public long StartDate { get; set; }
        public long EndDate { get; set; }
    }
}
