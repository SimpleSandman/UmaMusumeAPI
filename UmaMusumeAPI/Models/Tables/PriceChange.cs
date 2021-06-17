namespace UmaMusumeAPI.Models.Tables
{
    public class PriceChange
    {
        public int Id { get; set; }
        public long GroupId { get; set; }
        public long MinNum { get; set; }
        public long MaxNum { get; set; }
        public long PayItemNum { get; set; }
    }
}
