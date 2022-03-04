using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class Race
    {
        public int Id { get; set; }
        public int Group { get; set; }
        public int Grade { get; set; }
        public int CourseSet { get; set; }
        public int ThumbnailId { get; set; }
        public string FfCueName { get; set; }
        public string FfCuesheetName { get; set; }
        public int FfAnim { get; set; }
        public int FfCamera { get; set; }
        public int FfCameraSub { get; set; }
        public int FfSub { get; set; }
        public int GoalGate { get; set; }
        public int GoalFlower { get; set; }
        public int Audience { get; set; }
        public int EntryNum { get; set; }
    }
}
