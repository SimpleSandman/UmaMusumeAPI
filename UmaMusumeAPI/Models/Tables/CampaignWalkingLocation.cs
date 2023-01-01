using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class CampaignWalkingLocation
    {
        public int Id { get; set; }
        public int CutId { get; set; }
        public int CutSubId { get; set; }
        public string MaterialId { get; set; }
        public int BackgroundDataId { get; set; }
        public int RewardSetId { get; set; }
        public int LovePoint { get; set; }
        public int BgPositionCustom { get; set; }
        public int BgPositionX { get; set; }
    }
}
