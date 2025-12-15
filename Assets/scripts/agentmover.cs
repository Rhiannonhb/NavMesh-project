using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    public Transform player;        // The player the enemy will chase
    public float chaseRange = 10f;  // How close the player needs to be before the enemy follows

    private NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (player == null) return;

        float distance = Vector3.Distance(transform.position, player.position);

        // If player is close enough, chase them
        if (distance <= chaseRange)
        {
            agent.SetDestination(player.position);
        }
        else
        {
            // Stop moving when the player is far away
            agent.SetDestination(transform.position);
        }
    }
}