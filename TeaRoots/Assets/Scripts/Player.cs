using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("References")]
    public Rigidbody2D rb;
    public Animator anim;
    public Material mat;
    [Header("Settings")]
    public float JumpStrength = 50f;
    public float Speed = 10f;
    public float Wobble = 0f;
    public KeyCode KeyLeft = KeyCode.None;
    public KeyCode KeyRight = KeyCode.None;
    public KeyCode KeyJump = KeyCode.None;

    public bool canJump = true;

    void Start()
    {

    }

    void Update(){
        mat.SetFloat("_Wobble", Wobble / 100f);
    }

    void FixedUpdate()
    {
        if(canJump == true && Input.GetKey(KeyJump))
        {
            rb.AddForce(new Vector2(0f, JumpStrength));
            canJump = false;
        }

        if (Input.GetKey(KeyLeft))
        {
            rb.velocity = new Vector2(-Speed, rb.velocity.y);
            anim.SetBool("walk", true);
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
        else if (Input.GetKey(KeyRight))
        {
            rb.velocity = new Vector2(Speed, rb.velocity.y);
            anim.SetBool("walk", true);
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
        else
        {
            rb.velocity = new Vector2(0f, rb.velocity.y);
            anim.SetBool("walk", false);
        }

        anim.SetBool("jump", !canJump);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (rb.velocity.y <= 0f)
        {
            canJump = true;
        }
    }
}
