using UnityEngine;

namespace Mario
{
    public class KillerBlock : Tile
    {
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                Debug.Log(other.gameObject.tag);
                Player player = FindObjectOfType<Player>();

                if (player != null)
                {
                    player.Die();
                }
            }
        }
    }
}
