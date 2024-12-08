using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class SingleModeCookCookingRate
    {
        public int Id { get; set; }
        public int DishType { get; set; }
        public int CookingCuttId { get; set; }
        public int CookingNum { get; set; }
        public int SuccessRate { get; set; }
        public int GreatSuccessRate { get; set; }
        public int ConfirmedGreatSuccessRate { get; set; }
    }
}