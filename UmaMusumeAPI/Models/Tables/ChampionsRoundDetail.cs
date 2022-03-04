using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class ChampionsRoundDetail
    {
        public int Id { get; set; }
        public int ChampionsId { get; set; }
        public int LeagueType { get; set; }
        public int RoundId { get; set; }
        public int Round { get; set; }
        public int Tier { get; set; }
        public int RoundNumber { get; set; }
        public int BreakthroughNumber1 { get; set; }
        public int BreakthroughNumber2 { get; set; }
        public int EntryNumber { get; set; }
        public int FreeEntryNumber { get; set; }
    }
}
