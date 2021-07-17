using Mario;
using UnityEngine;

namespace MenuManagement
{
    public class Button : MonoBehaviour
    {
        [SerializeField] private AudioClip clickSound;

        public void OnButtonClick()
        {
            SoundManager.Instance.Play(clickSound);
        }
    }
}