using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponHit : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public EnemyHealth enemyHealth;
    //bool canHit = true;
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Player" && gameObject.tag!="PlayerWeapon")
        {
            if (playerHealth.hasCollideP==false) {
                //Debug.Log("got hit");
                playerHealth.hasCollideP = true;
                playerHealth.TakeDamage(1);
            }
        }
        if(collision.gameObject.tag == "enemy" && gameObject.tag!="Hammer") 
        {
            if (enemyHealth.hasCollideE == false)
            {
                //Debug.Log("got hit");
                enemyHealth.hasCollideE = true;
                enemyHealth.TakeDamage(1);
            }
        }
    }


}
