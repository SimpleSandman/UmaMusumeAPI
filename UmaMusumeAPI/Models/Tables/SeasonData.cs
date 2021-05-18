using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Tables
{
    public partial class SeasonData
    {
        public int Id { get; set; }
        public long Type { get; set; }
        public long Season { get; set; }
        public long Priority { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }
}
