using System;

namespace UmaMusumeAPI.Models.Views
{
    public class BasicItemDataInfo
    {
        public int ItemId { get; set; }
        public long ItemCategory { get; set; }
        public long GroupId { get; set; }
        public long ItemPlaceId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string ItemName { get; set; }
    }
}
