using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Tables
{
    public partial class RaceCondition
    {
        public int Id { get; set; }
        public long Season { get; set; }
        public long Weather { get; set; }
        public long Ground { get; set; }
        public long Rate { get; set; }
    }
}
