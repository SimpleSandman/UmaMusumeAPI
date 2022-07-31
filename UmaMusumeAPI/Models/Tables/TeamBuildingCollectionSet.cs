using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class TeamBuildingCollectionSet
    {
        public int Id { get; set; }
        public int TeamBuildingEventId { get; set; }
        public int CharaGroupId { get; set; }
        public int SkillId { get; set; }
    }
}
