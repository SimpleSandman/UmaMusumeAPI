using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class ChampionsRewardRate
    {
        public int Id { get; set; }
        public long ChampionsId { get; set; }
        public long LeagueType { get; set; }
        public long RoundId { get; set; }
        public long WinCount { get; set; }
        public long Ranking { get; set; }
        public long Rate { get; set; }
        public long RewardSetId { get; set; }
        public long BoxGrade { get; set; }
    }
}
