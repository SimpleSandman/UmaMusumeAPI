using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Tables
{
    public partial class CharaMotionSet
    {
        public int Id { get; set; }
        public string BodyMotion { get; set; }
        public long BodyMotionType { get; set; }
        public long BodyMotionPlayType { get; set; }
        public string FaceType { get; set; }
        public long Cheek { get; set; }
        public long EyeDefault { get; set; }
        public string EarMotion { get; set; }
        public string TailMotion { get; set; }
        public long TailMotionType { get; set; }
    }
}
