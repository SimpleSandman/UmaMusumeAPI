using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class PaidGachaButtonType
    {
        public int Id { get; set; }
        public int GachaCount { get; set; }
        public int PaidNum { get; set; }
        public int DrawGuaranteeRarity { get; set; }
    }
}
