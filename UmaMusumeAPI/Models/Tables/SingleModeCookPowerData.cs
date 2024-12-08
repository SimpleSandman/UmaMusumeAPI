using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class SingleModeCookPowerData
    {
        public int Id { get; set; }
        public int CookType { get; set; }
        public int TurnNum { get; set; }
        public int SuccessNum { get; set; }
        public int GreatSuccessNum { get; set; }
        public int GardenLv { get; set; }
    }
}