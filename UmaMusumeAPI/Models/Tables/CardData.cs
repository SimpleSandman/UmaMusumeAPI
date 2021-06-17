namespace UmaMusumeAPI.Models.Tables
{
    public class CardData
    {
        public int Id { get; set; }
        public long CharaId { get; set; }
        public long DefaultRarity { get; set; }
        public long LimitedChara { get; set; }
        public long AvailableSkillSetId { get; set; }
        public long TalentSpeed { get; set; }
        public long TalentStamina { get; set; }
        public long TalentPow { get; set; }
        public long TalentGuts { get; set; }
        public long TalentWiz { get; set; }
        public long TalentGroupId { get; set; }
        public long BgId { get; set; }
        public long GetPieceId { get; set; }
        public long RunningStyle { get; set; }
    }
}
