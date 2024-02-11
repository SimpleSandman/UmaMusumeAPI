using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class MapEventMapPoint
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public int MapPointId { get; set; }
        public int AreaId { get; set; }
        public int CheckPointFlag { get; set; }
        public int DispFlag { get; set; }
        public int NextEpisodeUnlockMapPointId { get; set; }
        public int GaugeNum { get; set; }
        public int StoryId1 { get; set; }
        public int StoryId2 { get; set; }
        public int ItemCategory1 { get; set; }
        public int ItemId1 { get; set; }
        public int ItemNum1 { get; set; }
        public int CharaId { get; set; }
        public int DressId { get; set; }
        public int MotionId { get; set; }
        public int NextEpisodeId { get; set; }
        public int StartDate { get; set; }
        public int MovieStartDate { get; set; }
    }
}
