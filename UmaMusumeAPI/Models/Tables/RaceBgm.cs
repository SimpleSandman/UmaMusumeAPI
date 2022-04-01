using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class RaceBgm
    {
        public int Id { get; set; }
        public int RaceType { get; set; }
        public int RaceInstanceId { get; set; }
        public int Grade { get; set; }
        public int SingleModeRouteRaceId { get; set; }
        public int SingleModeProgramId { get; set; }
        public string PaddockBgmCueName { get; set; }
        public string PaddockBgmCuesheetName { get; set; }
        public string EntrytableBgmCueName { get; set; }
        public string EntrytableBgmCuesheetName { get; set; }
        public int FirstBgmPattern { get; set; }
        public int SecondBgmPattern { get; set; }
        public string ResultCutinBgmCueName1 { get; set; }
        public string ResultCutinBgmCuesheetName1 { get; set; }
        public string ResultCutinBgmCueName2 { get; set; }
        public string ResultCutinBgmCuesheetName2 { get; set; }
        public string ResultCutinBgmCueName3 { get; set; }
        public string ResultCutinBgmCuesheetName3 { get; set; }
        public string ResultListBgmCueName1 { get; set; }
        public string ResultListBgmCuesheetName1 { get; set; }
        public string ResultListBgmCueName2 { get; set; }
        public string ResultListBgmCuesheetName2 { get; set; }
        public string ResultListBgmCueName3 { get; set; }
        public string ResultListBgmCuesheetName3 { get; set; }
        public int Difficulty { get; set; }
    }
}
