using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{
    public Canvas gameOverCanvas;
    public Slider healthbarslider;
    public Health health;

    private void Awake()
    {
        healthbarslider.value = 1f;
    }

    private void Update()
    {
        if (health.health==2)
        {
            healthbarslider.value = 0.66f;
        }
        else if (health.health==1)
        {
            healthbarslider.value = 0.33f;
        }
        else if (health.health==0)
        {
            healthbarslider.value = 0f;

            gameOverCanvas.gameObject.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
