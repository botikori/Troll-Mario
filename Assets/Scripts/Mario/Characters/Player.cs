using UnityEngine;
using System.Collections;

namespace Mario
{
    public class Player : Character
    {
        [SerializeField] private Animator animator;
        [SerializeField] private AudioClip jumpSound;
        [SerializeField] private float jumpDelay = 0.3f;
        private float _moveInput;
        private bool _canJump = true;

        protected override void Jump()
        {
            if (Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.UpArrow))
            {
                if (IsGrounded() && _canJump)
                {
                    _rigidbody.velocity = Vector2.up * jumpHeight;
                    SoundManager.PlaySound(jumpSound);
                    StartCoroutine(JumpDelay());
                }
            }
        }

        private IEnumerator JumpDelay()
        {
            _canJump = false;
            yield return new WaitForSeconds(jumpDelay);
            _canJump = true;
        }

        

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