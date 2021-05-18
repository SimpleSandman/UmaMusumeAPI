using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Tables
{
    public partial class ItemData
    {
        public int Id { get; set; }
        public long ItemCategory { get; set; }
        public long GroupId { get; set; }
        public long EffectType1 { get; set; }
        public long EffectTarget1 { get; set; }
        public long EffectValue1 { get; set; }
        public long EffectType2 { get; set; }
        public long EffectTarget2 { get; set; }
        public long EffectValue2 { get; set; }
        public long AddValue1 { get; set; }
        public long AddValue2 { get; set; }
        public long AddValue3 { get; set; }
        public long LimitNum { get; set; }
        public long Sort { get; set; }
        public long Rare { get; set; }
        public long EnableRequest { get; set; }
        public long RequestReward { get; set; }
        public long ItemPlaceId { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }
}
