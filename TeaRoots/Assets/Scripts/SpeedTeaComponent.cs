using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SpeedTeaComponent : MonoBehaviour
{
    public int respawntime = 18;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        TeaManager.Instance.StartSpeedTeaEffect();
        this.gameObject.SetActive(false);
        Invoke("DelayedReactivation", respawntime);
    }

    public void DelayedReactivation()
    {
        this.gameObject.SetActive(true);
    }
}