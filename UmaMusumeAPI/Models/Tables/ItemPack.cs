using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Tables
{
    public partial class ItemPack
    {
        public int Id { get; set; }
        public long ItemPackId { get; set; }
        public long ItemCategory { get; set; }
        public long ItemId { get; set; }
        public long ItemNum { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }
}
