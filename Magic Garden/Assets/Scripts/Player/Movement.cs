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
    zero
    }


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
            Result += Vector3.right * speed * Time.deltaTime;
            Now = Direction.right;

        }
        if (Input.GetKey(KeyCode.A))
        {
            Result += Vector3.left * speed * Time.deltaTime;
            Now = Direction.left;
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.LeftArrow))
        {
            Result += Vector3.down * speed * Time.deltaTime;

        }
        if (Input.GetKey(KeyCode.W))
        {
            Result += Vector3.up * speed * Time.deltaTime;

        }
        transform.position += Result;
        if (Now == Direction.right)
        {
            Left();
        }
        else if (Now == Direction.left)
        {
            Right();
        }
        else
        {
            Idle();
        }
    }
    void Idle()
    {
        animator.Play("Idle",0);
        
    }
    void Right()
    {
        animator.Play("RunRight");
    }

    void Left()
    {
        animator.Play("Run");
    }
}
