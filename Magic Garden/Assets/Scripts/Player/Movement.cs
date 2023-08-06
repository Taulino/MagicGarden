using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [Header("Characteristic")]
    public int speed = 5;
    public float VerticalSlow = 0.7f;  

    [Space(height:5f)]

    [Header("Another")]
    public Transform transform;
    public Animator animator;
    public SpriteRenderer spriteRenderer;

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
            Result += Vector3.down * speed * Time.deltaTime;

        }
        if (Input.GetKey(KeyCode.W))
        {
            Result += Vector3.up * speed * Time.deltaTime;

        }
        if (Result.x > 0)
        {
            Right();
        }
        else if(Result.x < 0)
        { 
            Left(); 
        }
        if(Result.x == 0)
        {
            Idle();
        }

        transform.position += Result;
        

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
        animator.Play("Run");
        Now = Direction.left;
    }
}
