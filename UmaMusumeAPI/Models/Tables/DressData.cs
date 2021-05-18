using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Tables
{
    public partial class DressData
    {
        public int Id { get; set; }
        public long ConditionType { get; set; }
        public long HaveMini { get; set; }
        public long CharaId { get; set; }
        public long UseGender { get; set; }
        public long BodyType { get; set; }
        public long BodyTypeSub { get; set; }
        public long BodySetting { get; set; }
        public long UseRace { get; set; }
        public long UseLive { get; set; }
        public long UseLiveTheater { get; set; }
        public long UseHome { get; set; }
        public long IsWet { get; set; }
        public long IsDirt { get; set; }
        public long HeadSubId { get; set; }
        public long UseSeason { get; set; }
        public string DressColorMain { get; set; }
        public string DressColorSub { get; set; }
        public long ColorNum { get; set; }
        public long DispOrder { get; set; }
        public long TailModelId { get; set; }
        public long TailModelSubId { get; set; }
        public long StartTime { get; set; }
        public long EndTime { get; set; }
    }
}
