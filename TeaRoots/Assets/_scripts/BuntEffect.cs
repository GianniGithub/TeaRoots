using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class BuntEffect : MonoBehaviour
{
    public Volume AllEffects;
    public ColorAdjustments ColorObj;
    public float value = -180f;
    public float speed = 1f;
    private LightLerp effect;

    private void Awake()
    {
        effect = GetComponent<LightLerp>();
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
    }

    void Update()
    {
        if (value >= 180f)
            value = -180f;
        value += Time.deltaTime * speed;
        ColorObj.hueShift.value = value;
    }
}
