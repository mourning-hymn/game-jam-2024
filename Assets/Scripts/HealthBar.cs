using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Image = UnityEngine.UI.Image;


public class HealthBar : MonoBehaviour
{

    public PlayerHealth playerHealth;
    public EnemyHealth enemyHealth;
    public Image fillImage;
    private Slider slider;

    // Start is called before the first frame update
    void Awake()
    {
        slider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        if(slider.value <= slider.minValue)
        {
            fillImage.enabled = false;
        }
        if(slider.value > slider.minValue && !fillImage.enabled)
        {
            fillImage.enabled = true;
        }

        float fillValue = playerHealth.currentHealthP / playerHealth.maxHealthP;

        if(fillValue <= slider.minValue/3)
        {
            fillImage.color = Color.white;
        }
        else if(fillValue > slider.maxValue / 3)
        {
            fillImage.color = Color.red;
        }

        slider.value = fillValue;
        playerHealth.hasCollideP = false;
        enemyHealth.hasCollideE = false;

    }

}