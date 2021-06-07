namespace UmaMusumeAPI.Models.Tables
{
    public partial class GachaPiece
    {
        public int Id { get; set; }
        public long Rarity { get; set; }
        public long PieceType { get; set; }
        public long PieceNum { get; set; }
        public long ItemCategory { get; set; }
        public long ItemId { get; set; }
    }
}
