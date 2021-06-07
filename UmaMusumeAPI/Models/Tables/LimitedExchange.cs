namespace UmaMusumeAPI.Models.Tables
{
    public partial class LimitedExchange
    {
        public int Id { get; set; }
        public long ItemExchangeTopId { get; set; }
        public long OpenValue { get; set; }
        public long ItemLineupValue { get; set; }
        public long OddsId { get; set; }
        public long DailyRaceOdds { get; set; }
        public long DailyRaceCeiling { get; set; }
        public long LegendRaceOdds { get; set; }
        public long LegendRaceCeiling { get; set; }
        public long SingleModeOdds { get; set; }
        public long SingleModeCeiling { get; set; }
        public long TeamStadiumOdds { get; set; }
        public long TeamStadiumCeiling { get; set; }
        public long StartDate { get; set; }
        public long EndDate { get; set; }
    }
}
