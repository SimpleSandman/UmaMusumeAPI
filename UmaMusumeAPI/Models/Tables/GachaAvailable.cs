namespace UmaMusumeAPI.Models.Tables
{
    public class GachaAvailable
    {
        public int GachaId { get; set; }
        public int CardId { get; set; }
        public int CardType { get; set; }
        public int Rarity { get; set; }
        public int Odds { get; set; }
        public int IsPickup { get; set; }
        public int RecommendOrder { get; set; }
        public int IsPrizeSelectable { get; set; }
    }
}
