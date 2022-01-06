using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class CampaignSingleRaceAddData
    {
        public int Id { get; set; }
        public long RaceAdditionalId { get; set; }
        public long RaceProgramId { get; set; }
        public long RaceAdditionalRewardId { get; set; }
        public long RewardLimit { get; set; }
    }
}
