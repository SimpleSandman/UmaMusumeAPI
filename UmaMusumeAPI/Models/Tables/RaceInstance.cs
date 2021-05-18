using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Tables
{
    public partial class RaceInstance
    {
        public int Id { get; set; }
        public long RaceId { get; set; }
        public long NpcGroupId { get; set; }
        public long Date { get; set; }
        public long Time { get; set; }
        public long RaceNumber { get; set; }
    }
}
