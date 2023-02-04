using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.Serialization;

public class ChromaticEffect : MonoBehaviour
{
    public Volume AllEffects;
    [FormerlySerializedAs("ColorObj")]
    public ChromaticAberration ChromaticObj;
    public float speed = 1f;
    private float value = 0f;
    void Start()
    {
        AllEffects.profile.TryGet(out ChromaticObj);
        enabled = false;
    }
    private void OnEnable()
    {
        ChromaticObj.intensity.value = 0f;
    }
    private void OnDisable()
    {
        ChromaticObj.intensity.value = 0f;
    }
    void Update()
    {
        value += Time.deltaTime * speed;
        ChromaticObj.intensity.value = value;
    }
}
