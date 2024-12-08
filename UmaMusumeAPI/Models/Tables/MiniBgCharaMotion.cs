using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class MiniBgCharaMotion
    {
        public int Id { get; set; }
        public int BgId { get; set; }
        public int GroupId { get; set; }
        public int SubGroupId { get; set; }
        public int IsMob { get; set; }
        public int MainCharaNum { get; set; }
        public string PosObj { get; set; }
        public string PositionFile { get; set; }
        public int GridPosX { get; set; }
        public int GridPosY { get; set; }
        public int Priority { get; set; }
        public string MotionName { get; set; }
        public string Timeline { get; set; }
        public string TimelineActor { get; set; }
        public int Direction { get; set; }
        public string CharaPosY { get; set; }
        public int CharaShadow { get; set; }
        public int UseGridPosJobSelect { get; set; }
        public string PositionAnim { get; set; }
        public int FixedRenderOrder { get; set; }
        public string SeCueName01 { get; set; }
        public string SeCueSheet01 { get; set; }
        public int SeStartFrame01 { get; set; }
        public string SeCueName02 { get; set; }
        public string SeCueSheet02 { get; set; }
        public int SeStartFrame02 { get; set; }
        public int EffectId { get; set; }
        public string EffectStartSec { get; set; }
        public string SecondPosObj { get; set; }
    }
}
