using System;
using System.Collections;
using System.Collections.Generic;
using QMGC.WallDemolition.internet;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class BuntEffect : MonoBehaviour
{
    public static BuntEffect Instance;

    public Volume AllEffects;
    public ColorAdjustments ColorObj;
    public float value = -180f;
    public float speed = 1f;
    public LightLerp effect;
    
    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        AllEffects.profile.TryGet(out ColorObj);
        enabled = false;
    }
    private void OnEnable()
    {
        effect.DoSize(true);
    }
    private void OnDisable()
    {
        effect.DoSize(false);
        ColorObj.hueShift.value = 0f;
    }

    void Update()
    {
        if (value >= 180f)
            value = -180f;
        value += Time.deltaTime * speed;
        ColorObj.hueShift.value = value;
    }
}
