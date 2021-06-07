namespace UmaMusumeAPI.Models.Tables
{
    public partial class StoryStill
    {
        public int Id { get; set; }
        public long StillId { get; set; }
        public long PageId { get; set; }
        public long OrderId { get; set; }
    }
}
