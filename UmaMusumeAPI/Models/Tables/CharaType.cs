namespace UmaMusumeAPI.Models.Tables
{
    public partial class CharaType
    {
        public string Id { get; set; }
        public long CharaId { get; set; }
        public long TargetScene { get; set; }
        public long TargetCut { get; set; }
        public long TargetType { get; set; }
        public long Value { get; set; }
    }
}
