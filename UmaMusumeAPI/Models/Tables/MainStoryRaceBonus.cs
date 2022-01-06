using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class MainStoryRaceBonus
    {
        public int Id { get; set; }
        public long GroupId { get; set; }
        public long BonusType { get; set; }
        public long BonusValue { get; set; }
        public long ConditionGroup { get; set; }
    }
}
