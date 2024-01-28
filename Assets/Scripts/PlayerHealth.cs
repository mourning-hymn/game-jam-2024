using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public float maxHealthP = 2000;
    public float currentHealthP;
    public float time = 1;
    public float timer = 0;
    public bool hasCollideP;

    private void Start() {
        currentHealthP = maxHealthP;
        hasCollideP = false;
    }
    public void TakeDamage(int amount)
    {
        //play sound here perhaps
        currentHealthP -= amount;
        if (currentHealthP <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
