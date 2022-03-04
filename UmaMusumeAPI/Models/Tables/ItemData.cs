using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class ItemData
    {
        public int Id { get; set; }
        public int ItemCategory { get; set; }
        public int GroupId { get; set; }
        public int EffectType1 { get; set; }
        public int EffectTarget1 { get; set; }
        public int EffectValue1 { get; set; }
        public int EffectType2 { get; set; }
        public int EffectTarget2 { get; set; }
        public int EffectValue2 { get; set; }
        public int AddValue1 { get; set; }
        public int AddValue2 { get; set; }
        public int AddValue3 { get; set; }
        public int LimitNum { get; set; }
        public int Sort { get; set; }
        public int Rare { get; set; }
        public int EnableRequest { get; set; }
        public int RequestReward { get; set; }
        public int ItemPlaceId { get; set; }
        public int SellItemId { get; set; }
        public int SellPrice { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }
}
