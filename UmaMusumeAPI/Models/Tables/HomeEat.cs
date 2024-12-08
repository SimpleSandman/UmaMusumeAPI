namespace UmaMusumeAPI.Models.Tables
{
    public class HomeEat
    {
        public int CharaId { get; set; }
        public int BodyShape { get; set; }
        public int PropIdRight { get; set; }
        public string PropEatAnimationRight { get; set; }
        public string OverrideMotionRight { get; set; }
        public int PropIdLeft { get; set; }
        public string PropEatAnimationLeft { get; set; }
        public string OverrideMotionLeft { get; set; }
        public string WalkMotion { get; set; }
        public string WalkCharaFaceType { get; set; }
        public string EatMotion { get; set; }
        public string EatFacialMotion { get; set; }
        public int Odds { get; set; }
        public int EventType { get; set; }
    }
}
