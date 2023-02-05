using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.SceneManagement;

public class TeaManager : MonoBehaviour
{
    public static TeaManager Instance { get; private set; }
    [SerializeField] int SightTeaDuration = 5;
    [SerializeField] int HalluTeaDuration = 5;
    [SerializeField] int SpeedTeaDuration = 5;
    [SerializeField] int GravTeaDuration = 5;
    [SerializeField] int SloMoTeaDuration = 5;
  
    [SerializeField] float SightStrengthPosEffect = 0.0f;
    [SerializeField] float SightStrengthBaseEffect = 0.75f;
    //[SerializeField] float SightStrengthNegEffect = 0.6f;
    [SerializeField] float SpeedStrengthPosEffect = 1.7f;
    [SerializeField] float GravityStrengthPosEffect = -5f;
    [SerializeField] float SloMoStrengthPosEffect = 0.3f;
    [SerializeField] List<GameObject> InvisiblePlatforms;


    public Player player;


    [SerializeField] Volume ppProfile;



    private void Awake()
    {
        ppProfile.profile.TryGet<Vignette>(out var vign);

        player = FindObjectOfType<Player>();
        //InvisiblePlatforms = new List<GameObject>();


        Instance = this;
    }

    //private void Start()
    //{
    //    InvisiblePlatforms.Add(GameObject.FindGameObjectWithTag("Invisible"));
    //}

    // HALLU TEA
    public void StartHalluTeaEffect()
    {
        
        Debug.Log("Hallu triggered");
        Sound.Instance.SoundEffect_Drink.Play();
        Sound.Instance.Soundtrack_High.volume = 1f;

        foreach (GameObject go in InvisiblePlatforms)
        {
            go.SetActive(true);
        }
        Invoke("StartHalluNegEffect", HalluTeaDuration);
    }

    public void StartHalluNegEffect()
    {
        Sound.Instance.Soundtrack_High.volume = 0f;
        foreach (var go in InvisiblePlatforms)
        {
            go.SetActive(false);
        }
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

    public void StartGravityTeaEffect()
    {
        KloneOma.Instance.enabled = true;
        Physics2D.gravity = new Vector2(0, GravityStrengthPosEffect);

        Invoke("StartGravityNegEffect", GravTeaDuration);
    }

    public void StartGravityNegEffect()
    {
        Physics2D.gravity = new Vector2(0, -9.81f);

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

    public void ReloadScene()
    {
		Debug.Log("test");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }

}
