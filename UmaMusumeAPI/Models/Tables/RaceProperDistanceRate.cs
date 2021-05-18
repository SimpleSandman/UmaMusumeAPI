using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Tables
{
    public partial class RaceProperDistanceRate
    {
        public int Id { get; set; }
        public long ProperRateSpeed { get; set; }
        public long ProperRatePower { get; set; }
    }
}
