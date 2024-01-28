using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponHit : MonoBehaviour
{
    public PlayerHealth playerHealth;
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("got hit");
            playerHealth.TakeDamage(1);
        }
    }


}