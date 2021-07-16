using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private AudioClip musicToPlay;

    public static void PlaySound(AudioClip soundToPlay)
    {
        if (soundToPlay != null)
        {
            GameObject soundGameObject = new GameObject("Sound");
            AudioSource audioSource = soundGameObject.AddComponent<AudioSource>();
            audioSource.PlayOneShot(soundToPlay); 
        }
    }

    private void PlayMusic()
    {
        if (musicToPlay != null)
        {
        }
    }
}
