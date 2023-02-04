using System.Collections;
using System.Collections.Generic;
using QMGC.WallDemolition.internet;
using UnityEngine;

public class SoundManager : Singleton<SoundManager>
{
    public AudioSource High, NichtHigh; 
    void Start()
    {
        High.volume = 0f;
    }
    public void EnableHigh(bool enable)
    {
        High.volume = enable ? 1f : 0f;
    }
    
}
