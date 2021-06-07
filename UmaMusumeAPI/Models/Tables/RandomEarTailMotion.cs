namespace UmaMusumeAPI.Models.Tables
{
    public partial class RandomEarTailMotion
    {
        public int Id { get; set; }
        public long PartsType { get; set; }
        public string MotionName { get; set; }
        public long EarType { get; set; }
        public long UseStory { get; set; }
    }
}
