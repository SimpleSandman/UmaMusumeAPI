using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Tables
{
    public partial class DailyRaceBilling
    {
        public int Id { get; set; }
        public long Frequency { get; set; }
        public long PayCost { get; set; }
    }
}
