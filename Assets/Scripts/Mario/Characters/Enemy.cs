using UnityEngine;

namespace Mario
{
    public abstract class Enemy : Character
    {
        [SerializeField] private Transform rightPos;
        [SerializeField] private Transform leftPos;
        [SerializeField] private SpriteRenderer spriteRenderer;
        
        private Vector2 _direction = Vector2.left;

        public Vector2 Direction
        {
            get => _direction;
            set => _direction = value;
        }

        protected override void Update()
        {
            base.Update();
            
            DetectEdges();
        }

        protected override void Move()
        {
            Rigidbody.velocity = new Vector2(_direction.x * moveSpeed, Rigidbody.velocity.y);
        }

        protected override void Jump()
        {
        }

        private void DetectEdges()
        {
            Vector2 rayRightStartPos = new Vector2(rightPos.position.x, rightPos.position.y);
            Vector2 rayLeftStartPos = new Vector2(leftPos.position.x, leftPos.position.y);
            
            RaycastHit2D rightHit = Physics2D.Raycast(rayRightStartPos, Vector2.down, 0.1f);
            RaycastHit2D leftHit = Physics2D.Raycast(rayLeftStartPos, Vector2.down, 0.1f);
            
            if (rightHit.collider == null && GetIsGrounded())
            {
                _direction = Vector2.right;
                spriteRenderer.flipX = true;
            }
            
            if (leftHit.collider == null && GetIsGrounded())
            {
                _direction = Vector2.left;
                spriteRenderer.flipX = false;
            }
        }
    }
}