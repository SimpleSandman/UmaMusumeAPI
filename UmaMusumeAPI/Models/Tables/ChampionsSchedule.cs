namespace UmaMusumeAPI.Models.Tables
{
    public partial class ChampionsSchedule
    {
        public int Id { get; set; }
        public long ResourceId { get; set; }
        public long InfoDetail1 { get; set; }
        public long InfoDetail2 { get; set; }
        public long ChampionsBgId { get; set; }
        public long ChampionsLeagueSelectBgSubId { get; set; }
        public long ChampionsBgSubId { get; set; }
        public long ChampionsFinishBgSubId { get; set; }
        public long ChampionsBgPositionX { get; set; }
        public long StartDate { get; set; }
        public long EndDate { get; set; }
        public long InfoDetail { get; set; }
        public long ChampionsFinishBgId { get; set; }
        public long ChampionsFinishBgPositionX { get; set; }
        public long NoticeDate { get; set; }
    }
}
