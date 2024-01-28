using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{

    public int maxHealth = 5;
    public int currentHealth;
    

    private bool isHit = false;


    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }
}
