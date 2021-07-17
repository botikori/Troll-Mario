using Mario;
using UnityEngine;

namespace Mario
{
    public class SoundManager : Singleton<SoundManager>
    {
        // Audio players components.
        [SerializeField] private AudioSource effectsSource;
        [SerializeField] private AudioSource musicSource;

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