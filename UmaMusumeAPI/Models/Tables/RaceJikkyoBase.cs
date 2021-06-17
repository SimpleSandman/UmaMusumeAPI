namespace UmaMusumeAPI.Models.Tables
{
    public class RaceJikkyoBase
    {
        public int Id { get; set; }
        public long Mode { get; set; }
        public long SubMode { get; set; }
        public long SubModeJump { get; set; }
        public long Situation { get; set; }
        public long SubSituation { get; set; }
        public long SituationEnd { get; set; }
        public long DisableReentrySituation { get; set; }
        public long Trigger0 { get; set; }
        public long Trigger1 { get; set; }
        public long Trigger2 { get; set; }
        public long Trigger3 { get; set; }
        public long Trigger4 { get; set; }
        public long Trigger5 { get; set; }
        public long Trigger6 { get; set; }
        public long Trigger7 { get; set; }
        public long Trigger8 { get; set; }
        public long Trigger9 { get; set; }
        public long MessageGroup { get; set; }
        public long CommentGroup { get; set; }
        public long Priority { get; set; }
        public long Per { get; set; }
        public long Immediate { get; set; }
        public long Discard { get; set; }
        public long Tension { get; set; }
        public long CameraId { get; set; }
        public long CameraHorse1 { get; set; }
        public long CameraHorse2 { get; set; }
        public long DisableReuse { get; set; }
    }
}
