using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Tables
{
    public partial class HighlightInterpolate
    {
        public int Id { get; set; }
        public long InTime { get; set; }
        public long OutTime { get; set; }
    }
}
