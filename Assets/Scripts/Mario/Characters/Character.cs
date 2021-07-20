using UnityEngine;

namespace Mario.Characters
{
    [RequireComponent(typeof(Rigidbody2D))]
    [RequireComponent(typeof(BoxCollider2D))]
    public abstract class Character : MonoBehaviour
    {
        [SerializeField] protected float moveSpeed = 10f;

        [SerializeField] protected float jumpHeight = 17f;

        protected Rigidbody2D Rigidbody;
        protected BoxCollider2D BoxCollider;

        [SerializeField] protected float groundCheckRaycastDistance = 0.1f;
        [SerializeField] private float gravityScale = 4;
        protected bool IsGrounded;
        private bool _isDisabled = false;

        protected virtual void Awake()
        {
            Rigidbody = GetComponent<Rigidbody2D>();
            
            BoxCollider = GetComponent<BoxCollider2D>();

            Rigidbody.gravityScale = gravityScale;
        }

        public virtual void Disable()
        {
            _isDisabled = true;
            Rigidbody.velocity = new Vector2(0, 0);
            Rigidbody.gravityScale = 0;
        }
        
        protected virtual void Update()
        {
            if (_isDisabled) { return; }
            Jump();
            Move();
        }

        protected bool GetIsGrounded()
        {
            RaycastHit2D raycastHit = Physics2D.BoxCast(BoxCollider.bounds.center, BoxCollider.bounds.size, 0, Vector2.down, 0.1f);

            return raycastHit.collider != null;
        }

        protected abstract void Jump();
        protected abstract void Move();
    }
}
