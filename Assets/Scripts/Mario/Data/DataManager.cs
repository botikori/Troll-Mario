using System.Collections.Generic;

namespace Mario.Data
{
    public class DataManager : Singleton<DataManager>
    {
        private SaveData _saveData;
        private JsonSaver _jsonSaver;

        public float MusicVolume
        {
            get { return _saveData.musicVolume; }
            set { _saveData.musicVolume = value; }
        }

        public float SoundEffectsVolume
        {
            get { return _saveData.soundEffectsVolume; }
            set { _saveData.soundEffectsVolume = value; }
        }

        public List<int> UnlockedLevels
        {
            get { return _saveData.unlockedLevels; }
            set { _saveData.unlockedLevels = value; }
        }

        public override void Awake()
        {
            base.Awake();
            
            _saveData = new SaveData();
            _jsonSaver = new JsonSaver();
            
            Load();
        }

        public void Save()
        {
            _jsonSaver.Save(_saveData);
        }

        private void Load()
        {
            _jsonSaver.Load(_saveData);
        }
    }
}