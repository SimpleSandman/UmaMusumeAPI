using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Tables
{
    public partial class TeamStadiumClass
    {
        public int Id { get; set; }
        public long TeamStadiumId { get; set; }
        public long TeamClass { get; set; }
        public long UnitMaxNum { get; set; }
        public long ClassUpRange { get; set; }
        public long ClassDownRange { get; set; }
    }
}
