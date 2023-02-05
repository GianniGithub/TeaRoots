using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SpeedTeaComponent : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("Speed Tea!");
            TeaManager.Instance.StartSpeedTeaEffect();
            KloneOma.Instance.Player = col.gameObject.transform;
            KloneOma.Instance.enabled = true;
        }
    }


}
