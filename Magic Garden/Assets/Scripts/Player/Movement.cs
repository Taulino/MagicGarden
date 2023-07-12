using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [Header("Characteristic")]
    public int speed = 3;

    [Space(height:5f)]

    [Header("Another")]
    public Transform transform;
    public Vector3 positionNow;

    void Start()
    {
        transform.GetComponent<Transform>();
        
    }

    
    void Update()
    {
        positionNow = transform.position;
        if (Input.GetKey(KeyCode.D)) 
        {
            transform.position = Vector3.MoveTowards(positionNow, new Vector3((positionNow.x + 1f),0),Time.deltaTime*speed);
              
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position = Vector3.MoveTowards(positionNow, new Vector3(-3f, 0), Time.deltaTime * speed);

        }
    }
}
