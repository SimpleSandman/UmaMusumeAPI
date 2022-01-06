using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class SkillLevelValue
    {
        public int Id { get; set; }
        public long AbilityType { get; set; }
        public long Level { get; set; }
        public long FloatAbilityValueCoef { get; set; }
    }
}
