using System;
using System.Collections;
using System.Collections.Generic;
using Gianni.Helper;
using UnityEngine;

public class ReSpown : MonoBehaviour
{
    public float Duration = 7f;
    private Vector3 StartVector;
    private void Awake()
    {
        StartVector = transform.position;
    }
    private void OnDisable()
    {
        TeaManager.Instance.InvokeWait(Duration, ()=> gameObject.SetActive(true));
    }
    private void OnEnable()
    {
        transform.position = StartVector;
    }

}
