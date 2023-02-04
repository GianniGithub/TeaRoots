using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SightTeaComponent : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Tea!");
        TeaManager.Instance.StartSightTeaEffect();
    }





}
