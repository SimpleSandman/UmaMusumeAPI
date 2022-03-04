using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class ChampionsNewsTrainerWininfo
    {
        public int Id { get; set; }
        public int RoundId { get; set; }
        public int RaceCountType { get; set; }
        public int WinMin { get; set; }
        public int WinMax { get; set; }
        public int TrainerTextGroup { get; set; }
    }
}
