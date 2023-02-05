using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SloMoTeaComponent : MonoBehaviour
{
    public int respawntime = 18;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        TeaManager.Instance.StartSloMoTeaEffect();
        this.gameObject.SetActive(false);
        Invoke("DelayedReactivation", respawntime);
    }

    public void DelayedReactivation()
    {
        this.gameObject.SetActive(true);
    }
}
