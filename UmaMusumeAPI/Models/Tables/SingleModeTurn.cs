using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class SingleModeTurn
    {
        public int Id { get; set; }
        public int TurnSetId { get; set; }
        public int Turn { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int Half { get; set; }
        public int Period { get; set; }
        public int UniqueCommand { get; set; }
        public int TrainingSetId { get; set; }
        public int OutingSetId { get; set; }
        public int TopClothId { get; set; }
        public int TopBgId { get; set; }
        public string BgmCueName { get; set; }
        public string BgmCuesheetName { get; set; }
        public string EnvCueName { get; set; }
        public string EnvCuesheetName { get; set; }
        public int RestType { get; set; }
        public int HealthRoomType { get; set; }
        public int RaceEntryType { get; set; }
        public int StoryClothId { get; set; }
        public int StoryBgId { get; set; }
        public int StoryBgSubId { get; set; }
    }
}
