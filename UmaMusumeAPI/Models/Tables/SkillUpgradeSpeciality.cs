using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class SkillUpgradeSpeciality
    {
        public int Id { get; set; }
        public int ScenarioId { get; set; }
        public int BaseSkillId { get; set; }
        public int SkillId { get; set; }
        public int StartDate { get; set; }
    }
}
