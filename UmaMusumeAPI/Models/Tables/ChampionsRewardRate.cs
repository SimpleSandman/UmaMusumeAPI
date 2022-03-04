using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class ChampionsRewardRate
    {
        public int Id { get; set; }
        public int ChampionsId { get; set; }
        public int LeagueType { get; set; }
        public int RoundId { get; set; }
        public int WinCount { get; set; }
        public int Ranking { get; set; }
        public int Rate { get; set; }
        public int RewardSetId { get; set; }
        public int BoxGrade { get; set; }
    }
}
