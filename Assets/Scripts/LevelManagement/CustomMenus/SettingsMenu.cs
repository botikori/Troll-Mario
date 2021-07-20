using Mario;
using Mario.Data;
using UnityEngine;
using UnityEngine.UI;

namespace MenuManagement
{
    public class SettingsMenu : Menu<SettingsMenu>
    {
        [SerializeField] private Slider musicVolumeSlider;
        [SerializeField] private Slider soundEffectsVolumeVolumeSlider;

        public void Start()
        {
            musicVolumeSlider.value = DataManager.Instance.MusicVolume;
            soundEffectsVolumeVolumeSlider.value = DataManager.Instance.SoundEffectsVolume;
        }

        public override void OnBackPressed()
        {
            DataManager.Instance.Save();
            base.OnBackPressed();
        }

        public void OnMusicVolumeChanged(float volume)
        {
            DataManager.Instance.MusicVolume = volume;
            SoundManager.Instance.UpdateVolumes();
        }

        public void OnSoundEffectsVolumeChanged(float volume)
        {
            DataManager.Instance.SoundEffectsVolume = volume;
            SoundManager.Instance.UpdateVolumes();
        }
    }
}