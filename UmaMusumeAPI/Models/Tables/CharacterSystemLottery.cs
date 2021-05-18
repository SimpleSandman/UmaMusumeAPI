using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Tables
{
    public partial class CharacterSystemLottery
    {
        public int Id { get; set; }
        public long CharaId { get; set; }
        public long CardId { get; set; }
        public long CardRarityId { get; set; }
        public long Trigger { get; set; }
        public long Param1 { get; set; }
        public long Per { get; set; }
        public long Priority { get; set; }
        public long SysTextId { get; set; }
    }
}
