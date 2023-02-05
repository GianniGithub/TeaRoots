using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropings : MonoBehaviour
{
    private Rigidbody2D rb;
    public Transform Player;
    public float TriggerDistansToX;
    public float DistanzToX;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DistanzToX = Mathf.Abs(Player.position.x - transform.position.x);
        if (DistanzToX < TriggerDistansToX)
        {
            enabled = false;
            rb.bodyType = RigidbodyType2D.Dynamic;
        }
    }
    
}
