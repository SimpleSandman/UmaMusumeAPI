using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class CharacterPropAnimation
    {
        public int Id { get; set; }
        public int PropId { get; set; }
        public int PropAnimId { get; set; }
        public int LayerIndex { get; set; }
        public string UseStateName { get; set; }
        public int SceneType { get; set; }
    }
}
