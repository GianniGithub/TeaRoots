using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Gianni.Helper;
using Unity.VisualScripting;

public class TeeSicht : MonoBehaviour
{
    public float duration;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("TeeSicht Tea!");
            BuntEffect.Instance.enabled = true;
            BuntEffect.Instance.InvokeWait(duration, () => BuntEffect.Instance.enabled = false);
        
            gameObject.SetActive(false);
        }
    }
}
