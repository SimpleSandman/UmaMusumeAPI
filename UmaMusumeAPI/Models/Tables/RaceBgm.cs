namespace UmaMusumeAPI.Models.Tables
{
    public class RaceBgm
    {
        public int Id { get; set; }
        public long RaceType { get; set; }
        public long RaceInstanceId { get; set; }
        public long Grade { get; set; }
        public long SingleModeRouteRaceId { get; set; }
        public long SingleModeProgramId { get; set; }
        public string PaddockBgmCueName { get; set; }
        public string PaddockBgmCuesheetName { get; set; }
        public string EntrytableBgmCueName { get; set; }
        public string EntrytableBgmCuesheetName { get; set; }
        public long FirstBgmPattern { get; set; }
        public long SecondBgmPattern { get; set; }
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
    }
}
