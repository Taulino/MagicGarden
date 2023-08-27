using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float speed = 3.0f;
    public GameObject player;
    public Transform transform;

    void Start()
    {
           
    }
    void Update()
    {
        Vector3 newPos = new Vector3(player.transform.position.x,player.transform.position.y,-10f);
        transform.position = Vector3.Lerp(transform.position,newPos, speed*Time.deltaTime);

    }
}
