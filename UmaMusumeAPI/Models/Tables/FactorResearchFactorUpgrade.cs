using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class FactorResearchFactorUpgrade
    {
        public int Id { get; set; }
        public int FactorType { get; set; }
        public int IsUpgradable { get; set; }
        public int FactorRarity { get; set; }
        public int UseItemNum { get; set; }
    }
}
