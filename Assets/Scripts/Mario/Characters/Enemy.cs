using UnityEngine;

namespace Mario
{
    public abstract class Enemy : Character
    {
        [SerializeField] private Transform leftSideRaycast;
        [SerializeField] private Transform rightSideRaycast;

        private Vector2 _direction = Vector2.left;

        protected override void Update()
        {
            //base.Update();

            TurnAround();
        }

        protected override void Move()
        {
            Rigidbody.velocity = new Vector2(_direction.x * moveSpeed, Rigidbody.velocity.y);
        }

        protected override void Jump()
        {
        }

        private void TurnAround()
        {
            
        }
    }
}