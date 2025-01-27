using UnityEngine;
using System.Collections;
using TMPro;

public class TakingDamage : MonoBehaviour
{
    public PlayerData playerData;
    private int currentHealth;
    private bool canTakeDamage = true;
    public float damageCooldown = 0.5f;

    public TextMeshProUGUI playerHealthText; // Reference to UI element

    void Start()
    {
        currentHealth = playerData.health;
        UpdateHealthText(); // Initialize HP text
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy") && canTakeDamage)
        {
            TakeDamage(10);
        }
    }

    public void TakeDamage(int damage)
    {
        if (!canTakeDamage) return;

        currentHealth -= damage;
        canTakeDamage = false;
        StartCoroutine(DamageCooldown());

        UpdateHealthText(); // Update UI

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    IEnumerator DamageCooldown()
    {
        yield return new WaitForSeconds(damageCooldown);
        canTakeDamage = true;
    }

    void UpdateHealthText()
    {
        if (playerHealthText != null)
        {
            playerHealthText.text = "HP: " + currentHealth.ToString();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}