namespace UmaMusumeAPI.Models.Tables
{
    public class HomeEat
    {
        public long CharaId { get; set; }
        public long BodyShape { get; set; }
        public long PropIdRight { get; set; }
        public string PropEatAnimationRight { get; set; }
        public string OverrideMotionRight { get; set; }
        public long PropIdLeft { get; set; }
        public string PropEatAnimationLeft { get; set; }
        public string OverrideMotionLeft { get; set; }
        public string WalkMotion { get; set; }
        public string WalkCharaFaceType { get; set; }
        public string EatMotion { get; set; }
        public string EatFacialMotion { get; set; }
        public long Odds { get; set; }
    }
}
