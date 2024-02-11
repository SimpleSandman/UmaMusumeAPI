using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class SelectPickup
    {
        public int Id { get; set; }
        public int GachaId { get; set; }
        public int CardId { get; set; }
        public int CardType { get; set; }
        public int RecommendOrder { get; set; }
        public int RecommendType { get; set; }
    }
}
