using UnityEngine;

namespace CyberLife
{
    [RequireComponent(typeof(PlayerMover))]
    [RequireComponent(typeof(PlayerJumper))]
    public class PlayerInput : MonoBehaviour
    {
        private PlayerMover _mover;
        private PlayerJumper _jumper;

        private float _horizontal;

        private void Awake()
        {
            _mover = GetComponent<PlayerMover>();
            _jumper = GetComponent<PlayerJumper>();
        }

        private void Update()
        {
            _horizontal = Input.GetAxis("Horizontal");

            if (Input.GetKeyDown(KeyCode.Space))
            {
                _jumper.TryJump();
            }
        }

        private void FixedUpdate()
        {
            _mover.Move(_horizontal);
        }
    }
}