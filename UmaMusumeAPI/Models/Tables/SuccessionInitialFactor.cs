using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Tables
{
    public partial class SuccessionInitialFactor
    {
        public int Id { get; set; }
        public long FactorType { get; set; }
        public long Value1 { get; set; }
        public long Value2 { get; set; }
        public long AddPoint { get; set; }
    }
}
