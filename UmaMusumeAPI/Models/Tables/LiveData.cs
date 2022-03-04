namespace UmaMusumeAPI.Models.Tables
{
    public class LiveData
    {
        public int MusicId { get; set; }
        public int Sort { get; set; }
        public int MusicType { get; set; }
        public string TitleColorTop { get; set; }
        public string TitleColorBottom { get; set; }
        public int ConditionType { get; set; }
        public int SongCharaType { get; set; }
        public int LiveMemberNumber { get; set; }
        public int DefaultMainDress { get; set; }
        public int DefaultMainDressColor { get; set; }
        public int DefaultMobDress { get; set; }
        public int DefaultMobDressColor { get; set; }
        public int BackdancerOrder { get; set; }
        public int BackdancerDress { get; set; }
        public int BackdancerDressColor { get; set; }
        public int HasLive { get; set; }
        public int StartDate { get; set; }
        public int EndDate { get; set; }
    }
}
