using System;

#nullable disable

namespace UmaMusumeAPI.Models.Views
{
    public partial class BasicPieceDataInfo
    {
        public int PieceId { get; set; }
        public long ItemPlaceId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string CharacterPieceName { get; set; }
    }
}
