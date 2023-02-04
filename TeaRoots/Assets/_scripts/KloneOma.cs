using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class KloneOma : MonoBehaviour
{
    private float t;
    public float CloneSpeedRate;
    public Player PlayerPrefap;
    [SerializeField]

    private void OnEnable()
    {

    }
    private void OnDisable()
    {

    }
    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        if (t > CloneSpeedRate)
        {
            t -= CloneSpeedRate;
            var pl = Instantiate(PlayerPrefap, transform.position, Quaternion.identity);
            var au = pl.AddComponent<AutoRunner>();
            au.SetUp(pl);
        }
    }
}
