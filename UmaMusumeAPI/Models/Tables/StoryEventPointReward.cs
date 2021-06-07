namespace UmaMusumeAPI.Models.Tables
{
    public partial class StoryEventPointReward
    {
        public int Id { get; set; }
        public long StoryEventId { get; set; }
        public long ItemCategory { get; set; }
        public long ItemId { get; set; }
        public long ItemNum { get; set; }
        public long Point { get; set; }
    }
}
