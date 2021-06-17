namespace UmaMusumeAPI.Models.Views
{
    public partial class BasicCardDataInfo
    {
        public int CardId { get; set; }
        public long CharaId { get; set; }
        public long DefaultRarity { get; set; }
        public long LimitedChara { get; set; }
        public long TalentSpeed { get; set; }
        public long TalentStamina { get; set; }
        public long TalentPow { get; set; }
        public long TalentGuts { get; set; }
        public long TalentWiz { get; set; }
        public string CardName { get; set; }
        public string CardTitle { get; set; }
    }
}
