using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class RaceBgmCutin
    {
        public int Id { get; set; }
        public int CardId { get; set; }
        public int BgmGroupId { get; set; }
        public int FadeoutTime { get; set; }
        public int ExclusiveControl { get; set; }
        public string ShortCutinBgmCueName { get; set; }
        public string ShortCutinBgmCuesheetName { get; set; }
        public string LongCutinBgmCueName { get; set; }
        public string LongCutinBgmCuesheetName { get; set; }
    }
}
