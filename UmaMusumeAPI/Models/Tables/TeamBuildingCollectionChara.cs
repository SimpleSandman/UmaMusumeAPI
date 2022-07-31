using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class TeamBuildingCollectionChara
    {
        public int Id { get; set; }
        public int TeamBuildingEventId { get; set; }
        public int CharaId { get; set; }
        public int ConditionType1 { get; set; }
        public int BonusType1 { get; set; }
        public int BonusValue1 { get; set; }
        public int ConditionType2 { get; set; }
        public int BonusType2 { get; set; }
        public int BonusValue2 { get; set; }
    }
}
