using System;

namespace UmaMusumeAPI.Models.Views
{
    public class BasicPieceDataInfo
    {
        public int PieceId { get; set; }
        public long ItemPlaceId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string CharacterPieceName { get; set; }
        public string CharacterPieceNameEnglish { get; set; }
    }
}
