namespace UmaMusumeAPI.Models.Tables
{
    public class LoginBonusData
    {
        public int Id { get; set; }
        public long Type { get; set; }
        public long CountNum { get; set; }
        public long DispOrder { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }
}
