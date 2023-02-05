using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Gianni.Helper;
using Random = UnityEngine.Random;
enum ControlCommand
{
    goLeft = 0,
    goRitgh = 1,
    idle = 2,
    jump = 3
    
    
}
public class AutoRunner : MonoBehaviour
{
    private ControlCommand currentWalk;
    private Player pl;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetUp(Player ple)
    {
        
        this.pl = ple;
        ple.enabled = false;
        this.InvokeWait(4f, () => Destroy(ple.gameObject));
        SetTimings();
        gameObject.tag = "Untagged";

    }
    void SetTimings()
    {
        var length = Random.Range(0.4f, 3.2f);
        currentWalk = (ControlCommand)Random.Range(0, 3);
        this.InvokeWait(length, SetTimings);
    }
    void FixedUpdate()
    {
        if (pl.canJump)
        {
            var hit = Physics2D.Raycast(transform.position, Vector2.down, 2f, LayerMask.GetMask("Default"));
            if (hit.collider == null)
            {
                pl.rb.AddForce(new Vector2(0f, pl.JumpStrength));
                pl.canJump = false;
            }
        }

        
        switch (currentWalk)
        {
            case ControlCommand.goLeft:
                pl.rb.velocity = new Vector2(-pl.Speed, pl.rb.velocity.y);
                pl.anim.SetBool("walk", true);
                transform.localScale = new Vector3(-1f, 1f, 1f);
                break;
            case ControlCommand.goRitgh:
                pl.rb.velocity = new Vector2(pl.Speed, pl.rb.velocity.y);
                pl.anim.SetBool("walk", true);
                transform.localScale = new Vector3(1f, 1f, 1f);
                break;
            case ControlCommand.jump:
                break;
            case ControlCommand.idle:
                
                    pl.rb.velocity = new Vector2(0f, pl.rb.velocity.y);
                    pl.anim.SetBool("walk", false);
                break; 
        }

    }
}
