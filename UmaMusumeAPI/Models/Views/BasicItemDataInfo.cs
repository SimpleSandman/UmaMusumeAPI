using System;

namespace UmaMusumeAPI.Models.Views
{
    public class BasicItemDataInfo
    {
        public int ItemId { get; set; }
        public int ItemCategory { get; set; }
        public int GroupId { get; set; }
        public int ItemPlaceId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string ItemName { get; set; }
    }
}
