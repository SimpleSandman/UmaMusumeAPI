using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Tables
{
    public partial class SuccessionRelationMember
    {
        public int Id { get; set; }
        public long RelationType { get; set; }
        public long CharaId { get; set; }
    }
}
