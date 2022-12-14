using System;
using RPG.Combat;
using RPG.Core;
using UnityEngine;

namespace RPG.Control
{
    public class AIController : MonoBehaviour
    {
        [SerializeField] private float chaseDistance = 5f;

        private Fighter _fighter;
        private Health _health;
        private GameObject _player;

        private void Start()
        {
            _fighter = GetComponent<Fighter>();
            _health = GetComponent<Health>();
            _player = GameObject.FindWithTag("Player");
        }

        private void Update()
        {
            if (_health.IsDead()) return;

            if (InAttackRangeOfPlayer() && _fighter.CanAttack(_player))
            {
                GetComponent<Fighter>().Attack(_player);
            }
            else
            {
                _fighter.Cancel();
            }
        }

        private bool InAttackRangeOfPlayer()
        {
            var distanceToPlayer = Vector3.Distance(_player.transform.position, transform.position);
            return distanceToPlayer < chaseDistance;
        }
    }
}

