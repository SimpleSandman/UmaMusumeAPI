namespace UmaMusumeAPI.Models.Tables
{
    public class CharacterSystemText
    {
        public int CharacterId { get; set; }
        public int VoiceId { get; set; }
        public string Text { get; set; }
        public string CueSheet { get; set; }
        public int CueId { get; set; }
        public int MotionSet { get; set; }
        public int Scene { get; set; }
        public int UseGallery { get; set; }
        public int CardId { get; set; }
        public string LipSyncData { get; set; }
        public int Gender { get; set; }
        public int MotionSecondSet { get; set; }
        public int MotionSecondStart { get; set; }
        public int StartDate { get; set; }
        public int GalleryKeyUsageCondition { get; set; }
    }
}
