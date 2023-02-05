using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hurtful : MonoBehaviour
{
    [SerializeField] Health health;

    private void Awake()
    {
        health = FindObjectOfType<Health>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("damaged");
            health.GotDamaged();
        }
      
    }

}
