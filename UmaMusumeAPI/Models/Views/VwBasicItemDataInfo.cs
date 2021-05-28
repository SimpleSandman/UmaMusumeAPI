﻿using System;

#nullable disable

namespace UmaMusumeAPI.Models.Views
{
    public partial class VwBasicItemDataInfo
    {
        public int Id { get; set; }
        public long ItemCategory { get; set; }
        public long GroupId { get; set; }
        public long ItemPlaceId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string ItemName { get; set; }
    }
}