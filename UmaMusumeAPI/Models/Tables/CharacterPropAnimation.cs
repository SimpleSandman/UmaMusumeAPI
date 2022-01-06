﻿using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class CharacterPropAnimation
    {
        public int Id { get; set; }
        public long PropId { get; set; }
        public long PropAnimId { get; set; }
        public long LayerIndex { get; set; }
        public string UseStateName { get; set; }
        public long SceneType { get; set; }
    }
}
