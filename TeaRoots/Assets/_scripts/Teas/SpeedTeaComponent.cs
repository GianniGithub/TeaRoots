using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SpeedTeaComponent : MonoBehaviour
{


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Tea!");
        TeaManager.Instance.StartSpeedTeaEffect();
    }





}
