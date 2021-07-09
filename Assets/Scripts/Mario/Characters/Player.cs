using UnityEngine;

namespace Mario
{
    public class Player : Character
    {
        [SerializeField] private Animator animator;
        private float _moveInput;

        protected override void Move()
        {
            _moveInput = Input.GetAxisRaw("Horizontal");
            _rigidbody.velocity = new Vector2(_moveInput * moveSpeed, _rigidbody.velocity.y);

            if (animator != null)
            {
                animator.SetFloat("Horizontal", Input.GetAxis("Horizontal"));
            }
        }
    }
}