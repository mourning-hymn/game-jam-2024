using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponHit : MonoBehaviour
{
    public PlayerHealth playerHealth;
    bool canHit = true;
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            if (playerHealth.hasCollide==false) {
                //Debug.Log("got hit");
                playerHealth.hasCollide = true;
                playerHealth.TakeDamage(1);
            }
        }
    }


}
