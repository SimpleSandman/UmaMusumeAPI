namespace UmaMusumeAPI.Models.Tables
{
    public class CharacterSystemText
    {
        public int CharacterId { get; set; }
        public int VoiceId { get; set; }
        public string Text { get; set; }
        public string CueSheet { get; set; }
        public long CueId { get; set; }
        public long MotionSet { get; set; }
        public long Scene { get; set; }
        public long UseGallery { get; set; }
        public long CardId { get; set; }
        public string LipSyncData { get; set; }
        public long Gender { get; set; }
        public long MotionSecondSet { get; set; }
        public long MotionSecondStart { get; set; }
    }
}
