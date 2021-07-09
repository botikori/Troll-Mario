using UnityEngine;

namespace Mario
{
    [RequireComponent(typeof(Rigidbody2D))]
    [RequireComponent(typeof(BoxCollider2D))]
    public abstract class Character : MonoBehaviour
    {
        [SerializeField] protected float moveSpeed = 10f;
        [SerializeField] protected float jumpHeight = 15f;

        protected Rigidbody2D _rigidbody;
        protected BoxCollider2D _boxCollider;

        [SerializeField] protected float groundCheckRaycastDistance = 0.1f;
        
        protected bool _isGrounded;

        protected virtual void Awake()
        {
            _rigidbody = GetComponent<Rigidbody2D>();
            _rigidbody.gravityScale = 2;
            _boxCollider = GetComponent<BoxCollider2D>();
        }

        protected virtual void Update()
        {
            Jump();
            Move();
        }

        protected virtual void Jump()
        {
            if (Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.UpArrow))
            {
                if (IsGrounded())
                {
                    _rigidbody.velocity = Vector2.up * jumpHeight;
                }
            }
        }

        protected bool IsGrounded()
        {
            RaycastHit2D raycastHit = Physics2D.BoxCast(_boxCollider.bounds.center, _boxCollider.bounds.size, 0, Vector2.down, 0.1f);

            return raycastHit.collider != null;
        }

        protected abstract void Move();
    }
}
