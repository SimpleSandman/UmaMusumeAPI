using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class SingleModeCookCookingCutt
    {
        public int Id { get; set; }
        public int CookingNum { get; set; }
        public int CookingMotionId1 { get; set; }
        public int CookingMotionId2 { get; set; }
        public int CookingMotionId3 { get; set; }
        public int CookingMotionId4 { get; set; }
        public int SuccessMotionId { get; set; }
        public string Camera { get; set; }
    }
}