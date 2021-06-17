namespace UmaMusumeAPI.Models.Tables
{
    public class LiveData
    {
        public int MusicId { get; set; }
        public long Sort { get; set; }
        public long MusicType { get; set; }
        public string TitleColorTop { get; set; }
        public string TitleColorBottom { get; set; }
        public long ConditionType { get; set; }
        public long SongCharaType { get; set; }
        public long LiveMemberNumber { get; set; }
        public long DefaultMainDress { get; set; }
        public long DefaultMainDressColor { get; set; }
        public long DefaultMobDress { get; set; }
        public long DefaultMobDressColor { get; set; }
        public long BackdancerOrder { get; set; }
        public long BackdancerDress { get; set; }
        public long BackdancerDressColor { get; set; }
        public long StartDate { get; set; }
        public long EndDate { get; set; }
    }
}
