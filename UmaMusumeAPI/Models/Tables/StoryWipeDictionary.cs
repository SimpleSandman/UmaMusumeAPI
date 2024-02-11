using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class StoryWipeDictionary
    {
        public int Id { get; set; }
        public string MotionRoot { get; set; }
        public int WipeId { get; set; }
        public int SubId { get; set; }
        public int Type { get; set; }
        public int DefaultLength { get; set; }
        public int OffsetLength { get; set; }
        public int VerticalExtendLength { get; set; }
        public int IgnoreTapLength { get; set; }
        public string SeName { get; set; }
        public string SheetName { get; set; }
        public int UseMini { get; set; }
        public string MiniMotionName { get; set; }
        public int MiniMotionStart { get; set; }
        public int MiniMotionEnd { get; set; }
        public string EmotionLabel { get; set; }
        public string EmotionLabelStart { get; set; }
        public string EmotionLabelEnd { get; set; }
        public string EmotionIcon { get; set; }
        public string EmotionIconStart { get; set; }
        public string EmotionIconEnd { get; set; }
    }
}
