using UnityEngine;

namespace Mario
{
    [RequireComponent(typeof(Rigidbody2D))]
    [RequireComponent(typeof(BoxCollider2D))]
    public abstract class Character : MonoBehaviour
    {
        [SerializeField] protected float moveSpeed = 10f;
        [SerializeField] protected float jumpHeight = 17f;

        protected Rigidbody2D _rigidbody;
        protected BoxCollider2D _boxCollider;

        [SerializeField] protected float groundCheckRaycastDistance = 0.1f;
        [SerializeField] private float gravityScale = 4;
        protected bool _isGrounded;

        protected virtual void Awake()
        {
            _rigidbody = GetComponent<Rigidbody2D>();
            _boxCollider = GetComponent<BoxCollider2D>();

            _rigidbody.gravityScale = gravityScale;
        }

        protected virtual void Update()
        {
            Jump();
            Move();
        }

        protected bool IsGrounded()
        {
            RaycastHit2D raycastHit = Physics2D.BoxCast(_boxCollider.bounds.center, _boxCollider.bounds.size, 0, Vector2.down, 0.1f);

            return raycastHit.collider != null;
        }

        protected abstract void Jump();
        protected abstract void Move();
    }
}
