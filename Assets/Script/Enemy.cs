using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public Transform player; // Target for the enemy to follow
    public float moveSpeed = 3.5f; // Movement speed (adjusted in NavMeshAgent)

    private NavMeshAgent agent;

    void Start()
    {
        // Get the NavMeshAgent component and configure its settings
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false; // Disable default rotation
        agent.updateUpAxis = false;   // Maintain 2D plane (important for NavMeshPlus)
        agent.speed = moveSpeed;     // Set movement speed
    }

    void Update()
    {
        // Set the destination to the player's position
        agent.SetDestination(player.position);

        // Rotate the enemy to face the player
        RotateTowards(player.position);
    }

    void RotateTowards(Vector3 target)
    {
        Vector3 direction = target - transform.position; // Direction to target
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg; // Calculate angle
        transform.rotation = Quaternion.Euler(0, 0, angle); // Apply rotation in 2D
    }
}