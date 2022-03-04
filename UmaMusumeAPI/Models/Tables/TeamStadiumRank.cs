using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class TeamStadiumRank
    {
        public int Id { get; set; }
        public int TeamRank { get; set; }
        public int TeamRankGroup { get; set; }
        public int TeamMinValue { get; set; }
        public int TeamMaxValue { get; set; }
        public int ItemCategory { get; set; }
        public int ItemId { get; set; }
        public int ItemNum { get; set; }
    }
}
