using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class HeroesLeagueRank
    {
        public int Id { get; set; }
        public int LeagueRankType { get; set; }
        public int LeagueRank { get; set; }
        public int LeagueMinValue { get; set; }
        public int LeagueMaxValue { get; set; }
        public int TicketNum { get; set; }
        public int RewardGroupId { get; set; }
        public string TopBgmCueName { get; set; }
        public string TopBgmCuesheetName { get; set; }
        public string RacingBaseBgmCueName { get; set; }
        public string RacingBaseBgmCuesheetName { get; set; }
    }
}
