using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class TrainingReportPass
    {
        public int Id { get; set; }
        public int SeasonId { get; set; }
        public int ProductMasterId { get; set; }
        public int InflationCoef { get; set; }
        public int NormalRewardSet { get; set; }
        public int SpecialRewardSet { get; set; }
        public string RemindDate { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string BgImage { get; set; }
        public int JobsTrainingReportPointLimit { get; set; }
    }
}
