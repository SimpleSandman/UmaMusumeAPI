namespace UmaMusumeAPI.Models.Tables
{
    public partial class AvailableSkillSet
    {
        public int Id { get; set; }
        public long AvailableSkillSetId { get; set; }
        public long SkillId { get; set; }
        public long NeedRank { get; set; }
    }
}
