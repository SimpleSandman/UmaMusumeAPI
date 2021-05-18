using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Tables
{
    public partial class Nickname
    {
        public int Id { get; set; }
        public long DispOrder { get; set; }
        public long GroupId { get; set; }
        public long Rank { get; set; }
        public long CharaDataId { get; set; }
        public long UserShow { get; set; }
        public long ReceiveConditionType { get; set; }
        public long StartDate { get; set; }
        public long EndDate { get; set; }
    }
}
