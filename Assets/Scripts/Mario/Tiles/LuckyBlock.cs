using UnityEngine;
using System.Collections.Generic;

namespace Mario
{
    public class LuckyBlock : Tile
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