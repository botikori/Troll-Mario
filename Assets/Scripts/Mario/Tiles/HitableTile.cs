using UnityEngine;
using System.Collections.Generic;

namespace Mario.Tiles
{
    public class HitableTile : Tile
    {
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                IBlockHit blockHit = GetComponent<IBlockHit>();

                if (blockHit != null)
                {
                    blockHit.BlockHit();
                }
            }
        }
    }
}