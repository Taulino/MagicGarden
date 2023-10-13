using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public enum ResourceType
{
    Crop,
    LAST
}
public class Player : MonoBehaviour
{
    public int[] Resources = new int[(int)ResourceType.LAST];

 
    public GameObject[] resources;


    public static Player player;
    private void Awake()
    {
        player = this;
    }
    void Start()
    {
        
    }
    void Update()
    {
        
    }



}
