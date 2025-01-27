using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject hitEffect;
    public int bulletDamage = 35; // Damage per bullet

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            return; // Ignore player collision
        }

        if (collision.gameObject.CompareTag("Enemy"))
        {
            // Damage the enemy
            Enemy enemy = collision.gameObject.GetComponent<Enemy>();
            if (enemy != null)
            {
                enemy.TakeDamage(bulletDamage);
            }
        }

        // Create hit effect and destroy bullet
        GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
        Destroy(effect, 0.5f);
    }
}