using System.Collections;
using System.Collections.Generic;
using QMGC.WallDemolition.internet;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;


public class TeaManager : Singleton<TeaManager>
{

    [SerializeField] int SightTeaDuration = 5;
    [SerializeField] int HalluTeaDuration = 5;
    [SerializeField] int SpeedTeaDuration = 5;
    [SerializeField] int GravTeaDuration = 5;
    [SerializeField] int SloMoTeaDuration = 5;
  
    [SerializeField] float SightStrengthPosEffect = 0.0f;
    [SerializeField] float SightStrengthBaseEffect = 0.75f;
    //[SerializeField] float SightStrengthNegEffect = 0.6f;
    [SerializeField] float SpeedStrengthPosEffect = 1.7f;
    [SerializeField] float GravityStrengthPosEffect = 3f;
    [SerializeField] float SloMoStrengthPosEffect = 0.3f;

    public PlatformCollection platforms;

    public Player player;


    [SerializeField] Volume ppProfile;


    private void Awake()
    {
        ppProfile.profile.TryGet<Vignette>(out var vign);
        player = FindObjectOfType<Player>();
        platforms = GetComponent<PlatformCollection>();
    }



    // HALLU TEA
    public void StartHalluTeaEffect()
    {
        Debug.Log("Hallu triggered");
        //Debug.Log(InvisiblePlatforms[0]);
        platforms.enabled = true;
    }

    public void StartHalluNegEffect()
    {
        platforms.enabled = false;
    }

    // SPEED TEA
    public void StartSpeedTeaEffect()
    {
        //character  speed hoch
        player.Speed = player.Speed * SpeedStrengthPosEffect;
        Invoke("StartSpeedNegEffect", SpeedTeaDuration);
    }

    public void StartSpeedNegEffect()
    {
        //char speed down
        player.Speed = player.Speed / SpeedStrengthPosEffect;
    }

    public void StartGravityJumpTeaEffect()
    {
        Physics2D.gravity = new Vector2(0, 9.81f/ GravityStrengthPosEffect);

        Invoke("StartGravityNegEffect", GravTeaDuration);
    }

    public void StartGravityNegEffect()
    {
        Physics2D.gravity = new Vector2(0, 9.81f * GravityStrengthPosEffect);

    }

    //SLOMO
    public void StartSloMoTeaEffect()
    {
        Time.timeScale = SloMoStrengthPosEffect;

        Invoke("StartSloMoNegEffect", SloMoTeaDuration);
    }

    public void StartSloMoNegEffect()
    {
        Time.timeScale = 1f;

    }



}
