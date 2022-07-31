using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class TeamBuildingRank
    {
        public int Id { get; set; }
        public int TeamRank { get; set; }
        public int TeamMinValue { get; set; }
        public int TeamMaxValue { get; set; }
        public int RewardGroupId { get; set; }
    }
}
