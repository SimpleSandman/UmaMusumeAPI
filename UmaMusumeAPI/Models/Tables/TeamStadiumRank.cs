using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class TeamStadiumRank
    {
        public int Id { get; set; }
        public long TeamRank { get; set; }
        public long TeamRankGroup { get; set; }
        public long TeamMinValue { get; set; }
        public long TeamMaxValue { get; set; }
        public long ItemCategory { get; set; }
        public long ItemId { get; set; }
        public long ItemNum { get; set; }
    }
}
