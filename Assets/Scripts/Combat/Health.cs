using UnityEngine;
using UnityEngine.Serialization;

namespace RPG.Combat
{
    public class Health : MonoBehaviour
    {
        [SerializeField] float healthPoints = 100f;

        private bool _isDead;

        public void TakeDamage(float damage)
        {
            healthPoints = Mathf.Max(healthPoints - damage, 0);
            if (healthPoints == 0) Die();
        }

        private void Die()
        {
            if (_isDead) return;
            
            _isDead = true;
            GetComponent<Animator>().SetTrigger("die");
        }
    }
}