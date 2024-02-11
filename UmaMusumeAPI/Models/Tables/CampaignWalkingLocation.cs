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
        public string BgmCueName { get; set; }
        public string BgmCuesheetName { get; set; }
        public string EnvCueName { get; set; }
        public string EnvCueSheetName { get; set; }
        public int FriendListId { get; set; }
        public string PlaceColorMain { get; set; }
        public string PlaceColorSub { get; set; }
        public int PlacePositionX { get; set; }
        public int PlacePositionY { get; set; }
    }
}
