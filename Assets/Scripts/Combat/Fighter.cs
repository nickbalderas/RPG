using RPG.Movement;
using UnityEngine;

namespace RPG.Combat
{
    public class Fighter : MonoBehaviour
    {
        [SerializeField] private float weaponRange = 2f;
        
        private Transform _target;
        
        private void Update()
        {
            if (!_target) return;

            if (_target && !GetIsInRange())
            {
                GetComponent<Mover>().MoveTo(_target.position);
            }
            else
            {
                GetComponent<Mover>().Stop();
            }
        }

        private bool GetIsInRange()
        {
            return Vector3.Distance(transform.position, _target.position) < weaponRange;
        }

        public void Attack(CombatTarget combatTarget)
        {
            _target = combatTarget.transform;
        }

        public void Cancel()
        {
            _target = null;
        }
    }
}