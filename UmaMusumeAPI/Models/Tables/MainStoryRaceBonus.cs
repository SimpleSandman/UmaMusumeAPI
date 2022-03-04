using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class MainStoryRaceBonus
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public int BonusType { get; set; }
        public int BonusValue { get; set; }
        public int ConditionGroup { get; set; }
    }
}
