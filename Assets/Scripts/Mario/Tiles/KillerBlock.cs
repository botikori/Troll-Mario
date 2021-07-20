using UnityEngine;
using Mario.Characters;

namespace Mario.Tiles
{
    public class KillerBlock : Tile
    {
        private void OnTriggerEnter2D(Collider2D other)
        {
            Debug.Log(other.gameObject.name);
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
