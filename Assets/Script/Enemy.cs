using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public Transform player;
    public EnemyData enemyData;
    private int currentHealth;

    private NavMeshAgent agent;
    private bool isRecovering = false;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
        agent.speed = enemyData.speed;

        currentHealth = enemyData.health; // Set initial HP
    }

    void Update()
    {
        if (!isRecovering)
        {
            agent.SetDestination(player.position);
            RotateTowards(player.position);
        }
    }

    void RotateTowards(Vector3 target)
    {
        Vector3 direction = target - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage; // Reduce HP

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject); // Destroy enemy object
    }
}