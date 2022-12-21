using UnityEngine;

namespace RPG.Control
{
    public class AIController : MonoBehaviour
    {
        [SerializeField] private float chaseDistance = 5f;

        private void Update()
        {
            DistanceToPlayer();
        }

        private void DistanceToPlayer()
        {
            GameObject player = GameObject.FindWithTag("Player");
            Vector3.Distance(player.transform.position, transform.position);
        }
    }
}

