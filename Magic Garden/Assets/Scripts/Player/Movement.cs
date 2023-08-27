using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [Header("Characteristic")]
    public float speed = 4.5f;
    public float VerticalSlow = 0.7f;  

    [Space(height:5f)]

    [Header("Another")]
    public Transform transform;
    public Animator animator;
    public SpriteRenderer spriteRenderer;
    public AudioSource audioSource;
    public AudioClip clipFoot;
    public bool canPlay = false;

    public enum Direction
    { 
    right,
    left,
    up,
    down,
    zero
    }
    public Direction Now = Direction.zero;

    void Start()
    {
        transform.GetComponent<Transform>();
        animator.GetComponent<Animator>();
        spriteRenderer.GetComponent<SpriteRenderer>();

    }

    
    void Update()
    {
        Direction Now = Direction.zero;
        Vector3 Result = Vector3.zero;

        if (Input.GetKey(KeyCode.D)||Input.GetKey(KeyCode.LeftArrow))
        {
            Now = Direction.right;
            Result += Vector3.right * speed * Time.deltaTime;
        }
        
        if (Input.GetKey(KeyCode.A))
        {
            Now = Direction.left;
            Result += Vector3.left * speed * Time.deltaTime; 
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.LeftArrow))
        {
            Now = Direction.down;
            Result += Vector3.down * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.W))
        {
            Now = Direction.up;
            Result += Vector3.up * speed * Time.deltaTime;

        }
       




        if (Result.x > 0 && Result.y == 0)
        {
            animator.StopPlayback();
           
            Right();
            
        }
        else if (Result.x < 0 && Result.y == 0)
        {
            animator.StopPlayback();
           
            Left();
        }
        if (Result.y < 0 && Result.x == 0)
        {
            animator.StopPlayback();
            
            Down();
        }
        else if (Result.y > 0 && Result.x == 0)
        {
            animator.StopPlayback();
           
            UP();
        }


        if (Result.y == 0 && Result.x == 0)
        {
            animator.StopPlayback();
           
            Idle();
        }

        transform.position += Result;

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
        {
            if (audioSource.isPlaying)
            {
                return;
            }
            else
            {
                audioSource.clip = clipFoot;
                audioSource.Play();
            }
        }
        else
        {
            audioSource.Stop();
        }


    }
   
    void Idle()
    {
        
        animator.Play("Idle",0);
        
    }
    void Right()
    {
       
        
        if (Now == Direction.right) return;
        transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, 0);
        animator.Play("Run");
        Now = Direction.right;
    }

    void Left()
    {
        
        if (Now == Direction.left) return;
        transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, 0);
        animator.Play("RunLeft");
        Now = Direction.left;
    }
    void UP()
    {
     
        if (Now == Direction.up) return;
        animator.Play("UpAnim");
        Now = Direction.up;
    }
    void Down()
    {
       
        if (Now == Direction.down) return;
        animator.Play("DownAnim");
        Now = Direction.down;
    }
}
