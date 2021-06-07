namespace UmaMusumeAPI.Models.Tables
{
    public partial class ChampionsNewsCharaComment
    {
        public int Id { get; set; }
        public long RoundId { get; set; }
        public long CharaId { get; set; }
        public long BigFlag { get; set; }
    }
}
