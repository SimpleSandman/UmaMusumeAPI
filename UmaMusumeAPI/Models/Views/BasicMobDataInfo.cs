﻿#nullable disable

namespace UmaMusumeAPI.Models.Views
{
    public partial class BasicMobDataInfo
    {
        public int MobId { get; set; }
        public long CharaFaceModel { get; set; }
        public long CharaHairModel { get; set; }
        public long CharaHairColor { get; set; }
        public long DressId { get; set; }
        public long DressColorId { get; set; }
        public string MobName { get; set; }
    }
}