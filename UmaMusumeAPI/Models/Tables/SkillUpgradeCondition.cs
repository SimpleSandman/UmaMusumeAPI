using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class SkillUpgradeCondition
    {
        public int Id { get; set; }
        public int DescriptionId { get; set; }
        public int Num { get; set; }
        public int SubNum { get; set; }
        public int TimingType { get; set; }
        public int CountType { get; set; }
    }
}
