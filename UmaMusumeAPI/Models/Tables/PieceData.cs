using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Tables
{
    public partial class PieceData
    {
        public int Id { get; set; }
        public long ItemPlaceId { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }
}
