namespace UmaMusumeAPI.Models.Tables
{
    public class Race
    {
        public int Id { get; set; }
        public long Group { get; set; }
        public long Grade { get; set; }
        public long CourseSet { get; set; }
        public long ThumbnailId { get; set; }
        public string FfCueName { get; set; }
        public string FfCuesheetName { get; set; }
        public long FfAnim { get; set; }
        public long FfCamera { get; set; }
        public long FfCameraSub { get; set; }
        public long FfSub { get; set; }
        public long GoalGate { get; set; }
        public long GoalFlower { get; set; }
        public long EntryNum { get; set; }
    }
}
