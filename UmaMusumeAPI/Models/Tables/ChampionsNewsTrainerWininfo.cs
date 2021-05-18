using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Tables
{
    public partial class ChampionsNewsTrainerWininfo
    {
        public int Id { get; set; }
        public long RoundId { get; set; }
        public long RaceCountType { get; set; }
        public long WinMin { get; set; }
        public long WinMax { get; set; }
        public long TrainerTextGroup { get; set; }
    }
}
