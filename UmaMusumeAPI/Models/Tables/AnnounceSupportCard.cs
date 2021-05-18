using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Tables
{
    public partial class AnnounceSupportCard
    {
        public int Id { get; set; }
        public long Type { get; set; }
        public long CutsPattern { get; set; }
        public long SupportCardIdA { get; set; }
        public long SupportCardIdB { get; set; }
        public long SupportCardIdC { get; set; }
    }
}
