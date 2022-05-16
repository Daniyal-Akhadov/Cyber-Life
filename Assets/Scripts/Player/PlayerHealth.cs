using System;
using UnityEngine;

namespace CyberLife
{
    public class PlayerHealth : MonoBehaviour, IDamageable
    {
        [SerializeField] private int _health = 5;

        public void TakeDamage(int damage)
        {
            if (damage <= 0)
                new ArgumentException("Damage less or equal 0");

            _health -= damage;

            if (_health <= 0)
                Die();
        }

        private void Die()
        {
            Destroy(gameObject);
        }
    }
}