namespace UmaMusumeAPI.Models.Tables
{
    public partial class AnnounceData
    {
        public int Id { get; set; }
        public long AnnounceType { get; set; }
        public long AnnounceId { get; set; }
        public long Priority { get; set; }
        public long StartDate { get; set; }
        public long EndDate { get; set; }
    }
}
