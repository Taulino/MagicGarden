using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public float Lerp = 0.9f;
    public GameObject Player;
    void Update()
    {
        Vector3 targetNew = new Vector3(Player.transform.position.x, Player.transform.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, targetNew, Lerp);
    }
}
