using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plattform : MonoBehaviour
{
    public bool AbleToKill;
    public bool DropByPlayerTouch;
    private Rigidbody2D rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        
    }
    
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            if(AbleToKill)
                MainEvents.Instance.OnPlayerDaid();
            
            if (DropByPlayerTouch)
            {
                rb.bodyType = RigidbodyType2D.Dynamic;
            }
        }
        
    }
}
