using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Tables
{
    public partial class AudioCuesheet
    {
        public int Id { get; set; }
        public string CueSheet { get; set; }
        public long Attribute { get; set; }
    }
}
