using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Tables
{
    public partial class MiniFaceTypeData
    {
        public string Label { get; set; }
        public long EyebrowL { get; set; }
        public long EyebrowR { get; set; }
        public long EyeL { get; set; }
        public long EyeR { get; set; }
        public long Mouth { get; set; }
        public long Cheek { get; set; }
    }
}
