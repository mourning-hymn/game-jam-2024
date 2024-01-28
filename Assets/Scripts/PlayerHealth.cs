using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float maxHealth = 5;
    public float currentHealth;
    public float time = 1;
    public float timer = 0;
    public bool hasCollide;

    private void Start() {
        currentHealth = maxHealth;
        hasCollide = false;
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
