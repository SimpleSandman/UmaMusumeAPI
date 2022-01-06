using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class MiniBgCharaMotion
    {
        public int Id { get; set; }
        public long BgId { get; set; }
        public long GroupId { get; set; }
        public long SubGroupId { get; set; }
        public long IsMob { get; set; }
        public long MainCharaNum { get; set; }
        public string PosObj { get; set; }
        public string PositionFile { get; set; }
        public long GridPosX { get; set; }
        public long GridPosY { get; set; }
        public long Priority { get; set; }
        public string MotionName { get; set; }
        public string Timeline { get; set; }
        public string TimelineActor { get; set; }
        public long Direction { get; set; }
        public string CharaPosY { get; set; }
        public long CharaShadow { get; set; }
        public long UseGridPosJobSelect { get; set; }
        public string PositionAnim { get; set; }
        public long FixedRenderOrder { get; set; }
        public string SeCueName01 { get; set; }
        public string SeCueSheet01 { get; set; }
        public long SeStartFrame01 { get; set; }
        public string SeCueName02 { get; set; }
        public string SeCueSheet02 { get; set; }
        public long SeStartFrame02 { get; set; }
        public long EffectId { get; set; }
        public string EffectStartSec { get; set; }
    }
}
