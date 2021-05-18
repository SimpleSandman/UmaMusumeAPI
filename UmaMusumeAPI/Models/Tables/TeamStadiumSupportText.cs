using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Tables
{
    public partial class TeamStadiumSupportText
    {
        public int Id { get; set; }
        public long Type { get; set; }
        public long MinBonus { get; set; }
        public long MaxBonus { get; set; }
    }
}
