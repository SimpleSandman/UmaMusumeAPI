using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class CollectEventMapMaster
    {
        public int Id { get; set; }
        public int BgDataId { get; set; }
        public int ShortEpisodeId { get; set; }
        public int TipsGroupId { get; set; }
        public int LoginBonusId { get; set; }
        public int BannerId { get; set; }
        public int CollectTapMaxPosIndex { get; set; }
        public int CollectTapRewardSetId { get; set; }
        public int CollectTapEndDate { get; set; }
        public int StartDate { get; set; }
        public int EventEndDate { get; set; }
        public int EndDate { get; set; }
    }
}
