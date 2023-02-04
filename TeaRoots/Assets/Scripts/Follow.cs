using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Follow : MonoBehaviour
{
    [Header("References")]
    public Camera Cam;
    public Transform Target;
    [Header("Settings")]
    public float Min;
    public float Max;

    private void LateUpdate(){
        Cam.transform.position = new Vector3(Target.position.x, Mathf.Clamp(Target.position.y, Min, Max), -10f);
    }
}
