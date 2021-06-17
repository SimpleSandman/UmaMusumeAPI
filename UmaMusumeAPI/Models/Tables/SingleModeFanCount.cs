namespace UmaMusumeAPI.Models.Tables
{
    public class SingleModeFanCount
    {
        public int Id { get; set; }
        public long FanSetId { get; set; }
        public long Order { get; set; }
        public long FanCount { get; set; }
    }
}
