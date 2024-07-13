using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int MinHealth { get; private set; } = 0;
    public int MaxHealth { get; private set; } = 100;
    public int CurrentHealth { get; private set; } = 100;

    private void Update()
    {
        if (CurrentHealth <= 0)
            Die();
    }

    public void TakeDamage(int damage)
    {
        CurrentHealth -= damage;
    }

    public void TakeHealing(int healPoints)
    {
        CurrentHealth = Mathf.Clamp(CurrentHealth + healPoints, MinHealth, MaxHealth);
    }

    private void Die()
    {
        float delay = 1.5f;

        Destroy(gameObject, delay);
    }
}