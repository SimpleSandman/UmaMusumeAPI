﻿using System;

#nullable disable

namespace UmaMusumeAPI.Models.Views
{
    public partial class VwBasicLiveDataInfo
    {
        public int MusicId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string SongName { get; set; }
    }
}