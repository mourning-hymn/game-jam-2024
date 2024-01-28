using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{

    public int maxHealth = 5;
    public int currentHealth;
    

    //private bool isHit = false;


    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }
    void TakeDamage(int amount)
    {
        //play sound here perhaps
        currentHealth -= amount;
        if (currentHealth < 0)
        {
            //game over screen
        }
    }
}
