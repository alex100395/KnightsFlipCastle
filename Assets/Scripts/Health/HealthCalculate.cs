using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCalculate : MonoBehaviour
{
    public int maxHealth = 10;
    public float currentHealth;
    public HealthBar healthBar;
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    void Update()
    {

    }
    public void TakeDamage()
    {
        currentHealth -= 1 * Time.deltaTime;
        healthBar.SetHealth(currentHealth);
    }
}
