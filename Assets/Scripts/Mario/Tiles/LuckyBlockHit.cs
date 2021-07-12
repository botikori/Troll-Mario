
using UnityEngine;

namespace Mario
{
    public class LuckyBlockHit : MonoBehaviour, IBlockHit
    {
        [SerializeField] private float hopAnimationTime = 1f;
        [SerializeField] private GameObject prefabToSpawn;
        [SerializeField] private float spawnOffset = 1f;
        [SerializeField] private Sprite openedSprite;

        private bool isOpen = false;

        public void BlockHit()
        {
            if (!isOpen)
            {
                isOpen = true;

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