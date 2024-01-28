using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 5;
    public int currentHealth;

    private void Start() {
        currentHealth = maxHealth;
    }
    public void TakeDamage(int amount)
    {
        //play sound here perhaps
        currentHealth -= amount;
        if (currentHealth < 0)
        {
            //game over screen
        }
    }
}
