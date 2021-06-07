namespace UmaMusumeAPI.Models.Tables
{
    public partial class SingleModeFanCount
    {
        public int Id { get; set; }
        public long FanSetId { get; set; }
        public long Order { get; set; }
        public long FanCount { get; set; }
    }
}
