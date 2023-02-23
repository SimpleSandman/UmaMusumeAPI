using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class SkillUpgradeDescription
    {
        public int Id { get; set; }
        public int CardId { get; set; }
        public int Rank { get; set; }
        public int SkillId { get; set; }
        public int StartDate { get; set; }
    }
}
