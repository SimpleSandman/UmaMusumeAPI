using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Tables
{
    public partial class TimezoneData
    {
        public int Timezone { get; set; }
        public long Priority { get; set; }
        public string StartHour { get; set; }
        public string EndHour { get; set; }
    }
}
