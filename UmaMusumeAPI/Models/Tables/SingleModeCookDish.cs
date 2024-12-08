using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class SingleModeCookDish
    {
        public int Id { get; set; }
        public int DishSetId { get; set; }
        public int DishGroupId { get; set; }
        public int Priority { get; set; }
        public int MaterialGroupId { get; set; }
        public int EffectGroupId { get; set; }
        public int SuccessEffectGroupId { get; set; }
        public int GainCoin { get; set; }
        public int GainPower { get; set; }
        public int SortOrder { get; set; }
        public int DishType { get; set; }
    }
}