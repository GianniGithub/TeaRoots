using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HalluTeaComponent : MonoBehaviour
{
    public int respawntime = 18;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        TeaManager.Instance.StartHalluTeaEffect();
        this.gameObject.SetActive(false);
        Invoke("DelayedReactivation", respawntime);
    }

    public void DelayedReactivation()
    {
        this.gameObject.SetActive(true);
    }
}
