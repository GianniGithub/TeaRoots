using QMGC.WallDemolition.internet;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{

    public static Sound Instance { get; private set; }

    public AudioSource Soundtrack_High;
    public AudioSource Soundtrack_Nüchtern;
    public AudioSource Soundtrack_Atmospheric;
    public AudioSource SoundEffect_Click;
    public AudioSource SoundEffect_FallingLog;
    public AudioSource SoundEffect_Jump;
    public AudioSource SoundEffect_Drink;
    public AudioSource SoundEffect_Hurt;
    public AudioSource SoundEffect_Ded;
    public AudioSource SoundEffect_Walk;


    private void Awake()
    {
        if(Instance != null && Instance !=this)
        {
            Destroy(this);

        }
        else
        {
            Instance = this;
        }
    }

}
