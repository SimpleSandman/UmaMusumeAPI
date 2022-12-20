namespace UmaMusumeAPI.Models.Tables
{
    public class JukeboxMusicData
    {
        public int MusicId { get; set; }
        public int Sort { get; set; }
        public int ConditionType { get; set; }
        public int IsHidden { get; set; }
        public int VersionType { get; set; }
        public int RequestType { get; set; }
        public int LampColor { get; set; }
        public int LampAnimation { get; set; }
        public int NameTextureLength { get; set; }
        public int SongType { get; set; }
        public string BgmCueNameShort { get; set; }
        public string BgmCuesheetNameShort { get; set; }
        public string BgmCueNameGamesize { get; set; }
        public string BgmCuesheetNameGamesize { get; set; }
        public int ShortLength { get; set; }
        public int StartDate { get; set; }
        public int EndDate { get; set; }
        public int AlterJacket { get; set; }
    }
}
