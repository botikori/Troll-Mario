
using UnityEngine;

namespace Mario.Tiles
{
    public class LuckyBlockHit : MonoBehaviour, IBlockHit
    {
        [SerializeField] private AudioClip hitSound;
        [SerializeField] private GameObject prefabToSpawn;
        [SerializeField] private float spawnOffset = 1f;
        [SerializeField] private Sprite openedSprite;

        private bool isOpen = false;

        public void BlockHit()
        {
            if (!isOpen)
            {
                isOpen = true;
                
                SoundManager.Instance.Play(hitSound);
                SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();

                if (spriteRenderer != null)
                {
                    spriteRenderer.sprite = openedSprite;
                }

                float relativeSpawnOffset = transform.position.y + spawnOffset;

                if (prefabToSpawn != null)
                {
                    Instantiate(prefabToSpawn, new Vector3(transform.position.x, relativeSpawnOffset, transform.position.z), Quaternion.identity);
                }
            }
        }
    }
}