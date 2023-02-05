using System;
using System.Collections;
using System.Collections.Generic;
using Gianni.Helper;
using Unity.VisualScripting;
using UnityEngine;

public class KloneOma : MonoBehaviour
{
    private float t;
    public float CloneSpeedRate;
    public Player PlayerPrefap;
    public Transform Player;
    public float Duration;
    public static KloneOma Instance;

    private void Awake()
    {
        Instance = this;
    }

    private void OnEnable()
    {
        this.InvokeWait(Duration, () => enabled = false);
    }
    void Update()
    {
        t += Time.deltaTime;
        if (t > CloneSpeedRate)
        {
            t -= CloneSpeedRate;
            var pl = Instantiate(PlayerPrefap, Player.transform.position, Quaternion.identity);
            var au = pl.AddComponent<AutoRunner>();
            au.SetUp(pl);
        }
    }
}
