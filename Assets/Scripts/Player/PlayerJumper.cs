using UnityEngine;

namespace CyberLife
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class PlayerJumper : MonoBehaviour
    {
        [SerializeField] private float _force = 250f;

        private Rigidbody2D _rigidbody;
        private bool _isGround;

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody2D>();
        }

        public void TryJump()
        {
            if (_isGround == true)
            {
                _rigidbody.AddForce(_force * Vector2.up);
                _isGround = false;
            }
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            var ground = collision.gameObject.GetComponent<Ground>();

            if (ground != null)
            {
                _isGround = true;
            }
        }
    }
}