namespace UmaMusumeAPI.Models.Tables
{
    public partial class GachaExchange
    {
        public int GachaId { get; set; }
        public int CardId { get; set; }
        public long CardType { get; set; }
        public long PayItemNum { get; set; }
    }
}
