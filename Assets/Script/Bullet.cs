using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject hitEffect;

    void Start()
    {
        // Destroy the bullet after 3 seconds if it doesn't collide with anything
        Destroy(gameObject, 3f);
    }
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the object has the "Player" tag
        if (collision.gameObject.CompareTag("Player"))
        {
            // Ignore collision with the player
            return;
        }

        // Instantiate the hit effect and destroy the bullet
        GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
        Destroy(effect, 0.5f);
    }
}