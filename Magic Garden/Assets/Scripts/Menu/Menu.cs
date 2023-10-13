using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;
using UnityEngine.UIElements;

public class Menu : MonoBehaviour
{
    public GameObject[] cloudsList;
    public float speed = 1f;
    public Vector3 LastPoint;
    public Vector3 startPoint;
    void Start()
    {
        LastPoint = new Vector3(-10,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        foreach (var item in cloudsList)
        {
            startPoint = item.transform.position;
            item.transform.position += Vector3.Lerp(item.transform.position, LastPoint, speed * Time.deltaTime);      
        
        }  

        
    }

}
