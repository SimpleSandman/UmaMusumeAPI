using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class CollectRaidStagingMiniChara
    {
        public int Id { get; set; }
        public int StagingMiniCharaGroupId { get; set; }
        public int StagingType { get; set; }
        public int CharaId { get; set; }
        public int DressId { get; set; }
        public int MiniMotionId { get; set; }
    }
}
