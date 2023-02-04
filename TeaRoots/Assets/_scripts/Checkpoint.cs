using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{

    [SerializeField] Health health;
    Vector3 coordinates;

    private void Awake()
    {
        coordinates = this.transform.position;
        health = FindObjectOfType<Health>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        health.SetRespawnCoordinates(this.transform.position);
    }


}
