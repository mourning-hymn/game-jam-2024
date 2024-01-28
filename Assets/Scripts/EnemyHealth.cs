using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float maxHealthE = 5;
    public float currentHealthE;
    public bool hasCollideE;
    // Start is called before the first frame update
    private void Start()
    {
        currentHealthE = maxHealthE;
        hasCollideE = false;
    }

    // Update is called once per frame
    public void TakeDamage(int amount)
    {
        //play sound here perhaps
        currentHealthE -= amount;
        if(currentHealthE <= 0 ) 
        {
            Destroy(gameObject);
        }
    }
}
