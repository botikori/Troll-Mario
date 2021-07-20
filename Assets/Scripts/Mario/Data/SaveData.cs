using System;
using System.Collections.Generic;
using UnityEngine.Serialization;

namespace Mario.Data
{
    [Serializable]
    public class SaveData
    {
        public float musicVolume;
        public float soundEffectsVolume;
        public List<int> unlockedLevels;
            
            
        public SaveData()
        {
            musicVolume = 1;
            soundEffectsVolume = 1;
            unlockedLevels = new List<int>();
        }
    }
}
