using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class JobsPointLimit
    {
        public int Id { get; set; }
        public int JobsStoryEventPointLimit { get; set; }
        public int JobsStoryEventRouletteCoinLimit { get; set; }
        public int JobsTrainingChallengeCoinLimit { get; set; }
    }
}