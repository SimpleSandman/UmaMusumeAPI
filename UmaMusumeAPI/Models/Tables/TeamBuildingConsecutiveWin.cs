using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class TeamBuildingConsecutiveWin
    {
        public int Id { get; set; }
        public int ConsecutiveWinsNum { get; set; }
        public int BonusValue { get; set; }
    }
}
