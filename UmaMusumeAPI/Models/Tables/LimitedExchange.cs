using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class LimitedExchange
    {
        public int Id { get; set; }
        public int ItemExchangeTopId { get; set; }
        public int OpenValue { get; set; }
        public int ItemLineupValue { get; set; }
        public int OddsId { get; set; }
        public int DailyRaceOdds { get; set; }
        public int DailyRaceCeiling { get; set; }
        public int LegendRaceOdds { get; set; }
        public int LegendRaceCeiling { get; set; }
        public int SingleModeOdds { get; set; }
        public int SingleModeCeiling { get; set; }
        public int TeamStadiumOdds { get; set; }
        public int TeamStadiumCeiling { get; set; }
        public int StartDate { get; set; }
        public int EndDate { get; set; }
    }
}
