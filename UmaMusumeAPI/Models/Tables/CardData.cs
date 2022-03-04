using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class CardData
    {
        public int Id { get; set; }
        public int CharaId { get; set; }
        public int DefaultRarity { get; set; }
        public int LimitedChara { get; set; }
        public int AvailableSkillSetId { get; set; }
        public int TalentSpeed { get; set; }
        public int TalentStamina { get; set; }
        public int TalentPow { get; set; }
        public int TalentGuts { get; set; }
        public int TalentWiz { get; set; }
        public int TalentGroupId { get; set; }
        public int BgId { get; set; }
        public int GetPieceId { get; set; }
        public int RunningStyle { get; set; }
    }
}
