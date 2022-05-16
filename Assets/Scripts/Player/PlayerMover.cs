using UnityEngine;

namespace CyberLife
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class PlayerMover : MonoBehaviour
    {
        [SerializeField] private float _speed = 5f;

        private Rigidbody2D _rigidbody;

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody2D>();
        }

        public void Move(float direction)
        {
            _rigidbody.velocity = new Vector2(direction * _speed * Time.deltaTime, _rigidbody.velocity.y);
        }
    }
}