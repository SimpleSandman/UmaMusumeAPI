using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class ChampionsRoundDetail
    {
        public int Id { get; set; }
        public long ChampionsId { get; set; }
        public long LeagueType { get; set; }
        public long RoundId { get; set; }
        public long Round { get; set; }
        public long Tier { get; set; }
        public long RoundNumber { get; set; }
        public long BreakthroughNumber1 { get; set; }
        public long BreakthroughNumber2 { get; set; }
        public long EntryNumber { get; set; }
        public long FreeEntryNumber { get; set; }
    }
}
