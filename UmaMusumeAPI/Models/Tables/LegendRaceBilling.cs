using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Tables
{
    public partial class LegendRaceBilling
    {
        public int Id { get; set; }
        public long Frequency { get; set; }
        public long PayCost { get; set; }
    }
}
