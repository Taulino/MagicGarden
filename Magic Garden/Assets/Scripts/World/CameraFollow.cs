using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public float speed = 3;
    public Transform target;
    public Vector3 NewTarget;

    void Start()
    {
       target.GetComponent<Transform>();
        NewTarget = target.position;
        NewTarget.z = 10;
    }
    void Update()
    {
        
        transform.position = Vector3.Lerp(transform.position, NewTarget, Time.deltaTime*speed);
    }
}
