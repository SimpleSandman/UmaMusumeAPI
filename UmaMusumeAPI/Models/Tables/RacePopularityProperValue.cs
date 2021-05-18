using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Tables
{
    public partial class RacePopularityProperValue
    {
        public int Id { get; set; }
        public long ProperType { get; set; }
        public long ProperGrade { get; set; }
        public long Value { get; set; }
    }
}
