using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class CharaMotionSet
    {
        public int Id { get; set; }
        public string BodyMotion { get; set; }
        public int BodyMotionType { get; set; }
        public int BodyMotionPlayType { get; set; }
        public string FaceType { get; set; }
        public int Cheek { get; set; }
        public int EyeDefault { get; set; }
        public string EarMotion { get; set; }
        public string TailMotion { get; set; }
        public int TailMotionType { get; set; }
    }
}
