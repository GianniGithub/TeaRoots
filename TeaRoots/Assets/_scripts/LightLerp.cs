using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using DG.Tweening;
using UnityEditor;
using UnityEngine.Serialization;

public class LightLerp : MonoBehaviour
{
    public Light2D light;
    public Vector2 Range;
    [FormerlySerializedAs("isOn")]
    public bool IsOn;

    public float t;
    [SerializeField]
    private float Speed;

    public void DoSize(bool to)
    {
        IsOn = to;
        t = to ? 0f : 1f;
    }
    
    void Update()
    {
        if (IsOn)
        {
            t += Time.deltaTime * Speed;
        }
        else
        {
            t -= Time.deltaTime * Speed;
        }
        light.pointLightInnerRadius = Mathf.Lerp(Range.x, Range.y, t);
    }
}
