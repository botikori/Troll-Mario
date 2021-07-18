using UnityEngine;

namespace Mario
{
    public class HiddenBlockHit : MonoBehaviour, IBlockHit
    {
        private bool isHidden = true;
        [SerializeField] private BoxCollider2D collisionBox;
        [SerializeField] private AudioClip hitSound;
        private SpriteRenderer _spriteRenderer;
        private Player _player;

        private void Awake() 
        {
            _spriteRenderer = GetComponent<SpriteRenderer>();
            _player = FindObjectOfType<Player>();
            
            ToggleBlock(false);
        }

        private void ToggleBlock(bool visible)
        {
            if (_spriteRenderer != null)
            {
                _spriteRenderer.enabled = visible;
            }
            if (collisionBox != null)
            {
                collisionBox.enabled = visible;
            }
        }

        public void BlockHit()
        {
            if (isHidden && _player.GetMoveDirection().y > 0)
            {
                isHidden = false;
                SoundManager.Instance.Play(hitSound);
                ToggleBlock(true);
            }
        }
    }
}