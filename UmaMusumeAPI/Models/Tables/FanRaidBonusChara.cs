using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class FanRaidBonusChara
    {
        public int Id { get; set; }
        public int FanRaidId { get; set; }
        public int CharaId { get; set; }
        public int AddFan { get; set; }
    }
}
