﻿#nullable disable

namespace UmaMusumeAPI.Models.Views
{
    public partial class BasicDressDataInfo
    {
        public int DressId { get; set; }
        public long CharaId { get; set; }
        public string Text { get; set; }
        public string DressColorMain { get; set; }
        public string DressColorSub { get; set; }
    }
}