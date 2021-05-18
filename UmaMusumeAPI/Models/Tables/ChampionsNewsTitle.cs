using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Tables
{
    public partial class ChampionsNewsTitle
    {
        public int Id { get; set; }
        public long RoundId { get; set; }
        public long WinPercentType { get; set; }
        public long ResourceId { get; set; }
        public long Title { get; set; }
        public long SubTitle { get; set; }
    }
}
