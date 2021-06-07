namespace UmaMusumeAPI.Models.Tables
{
    public partial class CardRarityData
    {
        public int Id { get; set; }
        public long CardId { get; set; }
        public long Rarity { get; set; }
        public long RaceDressId { get; set; }
        public long LiveDressId { get; set; }
        public long OutgameDressId { get; set; }
        public long MiniDressId { get; set; }
        public long SkillSet { get; set; }
        public long Speed { get; set; }
        public long Stamina { get; set; }
        public long Pow { get; set; }
        public long Guts { get; set; }
        public long Wiz { get; set; }
        public long MaxSpeed { get; set; }
        public long MaxStamina { get; set; }
        public long MaxPow { get; set; }
        public long MaxGuts { get; set; }
        public long MaxWiz { get; set; }
        public long ProperDistanceShort { get; set; }
        public long ProperDistanceMile { get; set; }
        public long ProperDistanceMiddle { get; set; }
        public long ProperDistanceLong { get; set; }
        public long ProperRunningStyleNige { get; set; }
        public long ProperRunningStyleSenko { get; set; }
        public long ProperRunningStyleSashi { get; set; }
        public long ProperRunningStyleOikomi { get; set; }
        public long ProperGroundTurf { get; set; }
        public long ProperGroundDirt { get; set; }
        public long GetDressId1 { get; set; }
        public long GetDressId2 { get; set; }
    }
}
