using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Tables
{
    public partial class RaceBibColor
    {
        public int Grade { get; set; }
        public int RaceId { get; set; }
        public long BibColor { get; set; }
        public long FontColor { get; set; }
    }
}
