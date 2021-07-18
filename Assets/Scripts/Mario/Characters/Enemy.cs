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
            base.Update();

            //TurnAround();
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
            if (GetIsGrounded())
            {
                if (_direction.y > 0)
                {
                    RaycastHit2D hit = Physics2D.Raycast(new Vector2(leftSideRaycast.position.x, leftSideRaycast.position.y), Vector2.down, groundCheckRaycastDistance);

                    if (hit.collider == null)
                    {
                        _direction = Vector2.left;
                    }
                }
                else
                {
                    RaycastHit2D hit = Physics2D.Raycast(new Vector2(rightSideRaycast.position.x, rightSideRaycast.position.y), Vector2.down, groundCheckRaycastDistance);

                    if (hit.collider == null)
                    {
                        _direction = Vector2.right;
                    }
                }
            }
        }
    }
}