using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Tables
{
    public partial class SuccessionRental
    {
        public int Id { get; set; }
        public long RentalRank { get; set; }
        public long RentalNum { get; set; }
        public long UseValue1 { get; set; }
        public long UseValue2 { get; set; }
    }
}
