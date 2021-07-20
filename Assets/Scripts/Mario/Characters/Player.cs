using UnityEngine;
using System.Collections;

namespace Mario.Characters
{
    public class Player : Character
    {
        [SerializeField] private Animator animator;
        
        [SerializeField] private AudioClip jumpSound;
        [SerializeField] private float jumpDelay = 0.3f;
        
        [SerializeField] private int maxFallDistance = -50;

        private float _moveInput;
        private bool _canJump = true;

        #region Jump
        protected override void Jump()
        {
            if (Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.UpArrow))
            {
                if (GetIsGrounded() && _canJump)
                {
                    Rigidbody.velocity = Vector2.up * jumpHeight;
                    SoundManager.Instance.Play(jumpSound);
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
        #endregion

        protected override void Update()
        {
            base.Update();

            if (transform.position.y < maxFallDistance)
            {
                Die();
            }

            animator.SetBool("IsGrounded", GetIsGrounded());
        }

        public void Die()
        {
            GameManager gameManager = FindObjectOfType<GameManager>();
            gameManager.GameOver();
        }

        protected override void Move()
        {
            _moveInput = Input.GetAxisRaw("Horizontal");
            Rigidbody.velocity = new Vector2(_moveInput * moveSpeed, Rigidbody.velocity.y);

            if (animator != null)
            {
                animator.SetFloat("Horizontal", Input.GetAxis("Horizontal"));
            }
        }
        
        public Vector3 GetMoveDirection()
        {
            Vector3 localVelocity = transform.InverseTransformDirection(Rigidbody.velocity);
            return localVelocity;
        }
    }
}