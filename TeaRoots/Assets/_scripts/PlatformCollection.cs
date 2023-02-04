using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class PlatformCollection : MonoBehaviour
{
    public List<GameObject> InvisiblePlatforms;
    private void OnEnable()
    {
        SetPlatfrom(true);

    }
    private void OnDisable()
    {
        SetPlatfrom(false);
    }

    void SetPlatfrom(bool to)
    {
        foreach (var platform in InvisiblePlatforms)
        {
            platform.SetActive(to);
        }
    }
}
