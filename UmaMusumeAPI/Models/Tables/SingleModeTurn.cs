using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Tables
{
    public partial class SingleModeTurn
    {
        public int Id { get; set; }
        public long TurnSetId { get; set; }
        public long Turn { get; set; }
        public long Year { get; set; }
        public long Month { get; set; }
        public long Half { get; set; }
        public long Period { get; set; }
        public long UniqueCommand { get; set; }
        public long TrainingSetId { get; set; }
        public long OutingSetId { get; set; }
        public long TopClothId { get; set; }
        public long TopBgId { get; set; }
        public string BgmCueName { get; set; }
        public string BgmCuesheetName { get; set; }
        public string EnvCueName { get; set; }
        public string EnvCuesheetName { get; set; }
        public long RestType { get; set; }
        public long HealthRoomType { get; set; }
        public long RaceEntryType { get; set; }
        public long StoryClothId { get; set; }
        public long StoryBgId { get; set; }
        public long StoryBgSubId { get; set; }
    }
}
