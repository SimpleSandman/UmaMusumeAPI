using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class SingleModeCookGardenLevel
    {
        public int Id { get; set; }
        public int FacilityId { get; set; }
        public int GardenLv { get; set; }
        public int FacilityLv { get; set; }
        public int EffectGroupId { get; set; }
        public int CoinNum { get; set; }
    }
}