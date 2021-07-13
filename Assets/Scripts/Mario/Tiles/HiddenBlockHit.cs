
using UnityEngine;

namespace Mario
{
    public class HiddenBlockHit : MonoBehaviour, IBlockHit
    {
        private bool isHidden = true;
        [SerializeField] private BoxCollider2D collisionBox;
        private SpriteRenderer _spriteRenderer;

        private void Awake() 
        {
            _spriteRenderer = GetComponent<SpriteRenderer>();

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
            if (isHidden)
            {
                isHidden = false;
                ToggleBlock(true);
            }
        }
    }
}