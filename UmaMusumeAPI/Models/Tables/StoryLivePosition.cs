namespace UmaMusumeAPI.Models.Tables
{
    public partial class StoryLivePosition
    {
        public int Id { get; set; }
        public long SetId { get; set; }
        public long MusicId { get; set; }
        public long PositionId { get; set; }
        public long CharaType { get; set; }
        public long CharaId { get; set; }
        public long DressId { get; set; }
        public long DressColor { get; set; }
        public long SecondDressId { get; set; }
        public long SecondDressColor { get; set; }
        public long VocalCharaId { get; set; }
    }
}
