using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class SingleModeCookSuccessType
    {
        public int Id { get; set; }
        public int SuccessMotionId { get; set; }
        public int SuccessMotionSwap1Id { get; set; }
        public int SuccessMotionSwap2Id { get; set; }
        public string SuccessEffectName { get; set; }
        public int SuccessEffectPosition { get; set; }
        public string SuccessEffectSwap1Name { get; set; }
        public string SuccessEffectSwap2Name { get; set; }
    }
}