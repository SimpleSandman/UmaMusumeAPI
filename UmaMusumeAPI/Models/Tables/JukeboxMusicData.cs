namespace UmaMusumeAPI.Models.Tables
{
    public class JukeboxMusicData
    {
        public int MusicId { get; set; }
        public long Sort { get; set; }
        public long ConditionType { get; set; }
        public long IsHidden { get; set; }
        public long VersionType { get; set; }
        public long RequestType { get; set; }
        public long LampColor { get; set; }
        public long LampAnimation { get; set; }
        public long NameTextureLength { get; set; }
        public long SongType { get; set; }
        public string BgmCueNameShort { get; set; }
        public string BgmCuesheetNameShort { get; set; }
        public string BgmCueNameGamesize { get; set; }
        public string BgmCuesheetNameGamesize { get; set; }
        public long ShortLength { get; set; }
        public long StartDate { get; set; }
        public long EndDate { get; set; }
    }
}
