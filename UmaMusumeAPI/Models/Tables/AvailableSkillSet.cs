using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class AvailableSkillSet
    {
        public int Id { get; set; }
        public int AvailableSkillSetId { get; set; }
        public int SkillId { get; set; }
        public int NeedRank { get; set; }
    }
}
