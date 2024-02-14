using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class LoginBonusData
    {
        public int Id { get; set; }
        public int Type { get; set; }
        public int CountNum { get; set; }
        public int DispOrder { get; set; }
        public int StampId { get; set; }
        public int BgId { get; set; }
        public int GroupId { get; set; }
        public int Step { get; set; }
        public int GiftMessageId { get; set; }
        public int AnimeFileId { get; set; }
        public string AnimeFileLabel { get; set; }
        public string NewStartDate { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }
}
