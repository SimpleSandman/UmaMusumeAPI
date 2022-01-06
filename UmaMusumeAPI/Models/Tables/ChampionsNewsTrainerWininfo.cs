using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class ChampionsNewsTrainerWininfo
    {
        public int Id { get; set; }
        public long RoundId { get; set; }
        public long RaceCountType { get; set; }
        public long WinMin { get; set; }
        public long WinMax { get; set; }
        public long TrainerTextGroup { get; set; }
    }
}
