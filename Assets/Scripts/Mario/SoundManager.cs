using System;
using Mario;
using Mario.Data;
using UnityEngine;

namespace Mario
{
    public class SoundManager : Singleton<SoundManager>
    {
        // Audio players components.
        [SerializeField] private AudioSource effectsSource;
        [SerializeField] private AudioSource musicSource;

        private void Start()
        {
            UpdateVolumes();
        }

        public void UpdateVolumes()
        {
            effectsSource.volume = DataManager.Instance.SoundEffectsVolume;
            musicSource.volume = DataManager.Instance.MusicVolume;
        }

        // Play a single clip through the sound effects source.
        public void Play(AudioClip clip)
        {
            effectsSource.clip = clip;
            effectsSource.Play();
        }

        // Play a single clip through the music source.
        public void PlayMusic(AudioClip clip)
        {
            musicSource.clip = clip;
            musicSource.Play();
        }
    }
}