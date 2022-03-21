using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class FanRaidBonusSupportCard
    {
        public int Id { get; set; }
        public int FanRaidId { get; set; }
        public int SupportCardId { get; set; }
        public int AddFan { get; set; }
    }
}
