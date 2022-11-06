using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class BannerData
    {
        public int Id { get; set; }
        public int BannerId { get; set; }
        public int Type { get; set; }
        public int GroupId { get; set; }
        public int Transition { get; set; }
        public int Priority { get; set; }
        public int ConditionValue { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public int BannerImageId { get; set; }
        public int DialogImageId { get; set; }
    }
}
