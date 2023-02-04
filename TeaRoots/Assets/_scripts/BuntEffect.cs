using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class BuntEffect : MonoBehaviour
{
    public Volume AllEffects;
    public ColorAdjustments ColorObj;
    public float value = -180f;
    public float speed = 1f;
    void Start()
    {
        AllEffects.profile.TryGet(out ColorObj);
        enabled = false;
    }
    
    void Update()
    {
        if (value >= 180f)
            value = -180f;
        value += Time.deltaTime * speed;
        ColorObj.hueShift.value = value;
    }
}
