using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class SingleModeCookCookingType
    {
        public int Id { get; set; }
        public int CookingMotionId { get; set; }
        public int SwapType { get; set; }
        public int CookingMotionSwapId { get; set; }
        public string CookingEffectName1 { get; set; }
        public int CookingEffectPosition1 { get; set; }
        public string CookingEffectName2 { get; set; }
        public int CookingEffectPosition2 { get; set; }
        public string CookingEffectSwapName1 { get; set; }
        public int CookingEffectSwapPosition1 { get; set; }
        public string CookingEffectSwapName2 { get; set; }
        public int CookingEffectSwapPosition2 { get; set; }
    }
}