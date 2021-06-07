namespace UmaMusumeAPI.Models.Tables
{
    public partial class ChampionsNewsCharaDetail
    {
        public int Id { get; set; }
        public long CharaTextGroup { get; set; }
        public long TextNumber { get; set; }
        public long ResourceId { get; set; }
        public long CharaId { get; set; }
        public long SingleWin { get; set; }
        public long NicknameId { get; set; }
        public long ParameterType { get; set; }
        public long ParameterMin { get; set; }
        public long RunningStyle { get; set; }
        public long ProperRunningStyleMin { get; set; }
    }
}
