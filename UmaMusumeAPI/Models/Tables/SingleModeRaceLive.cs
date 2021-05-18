using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Tables
{
    public partial class SingleModeRaceLive
    {
        public int Id { get; set; }
        public long Grade { get; set; }
        public long RaceInstanceId { get; set; }
        public long MusicId { get; set; }
    }
}
