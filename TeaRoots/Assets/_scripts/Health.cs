using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int health=3;
    Vector3 respawnCoordinates;

    private void Start()
    {
        respawnCoordinates = this.transform.position;
    }

    public void SetRespawnCoordinates(Vector3 coordinates)
    {
        respawnCoordinates = coordinates;
    }


    public void GotDamaged()
    {
        health -= 1;

        if (health > 0)
        {
            Sound.Instance.SoundEffect_Hurt.Play();
            gameObject.transform.position = respawnCoordinates;
        }
        else
        {
            Sound.Instance.Soundtrack_High.volume = 0;
            Sound.Instance.SoundEffect_Ded.Play();

            Time.timeScale = 0f;
        }
    }
}
