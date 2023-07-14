using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum ResourceType
{
    Crop,
    LAST
}
public class Player : MonoBehaviour
{
    public int[] Resources = new int[(int)ResourceType.LAST];

    public static Player player;
    private void Awake()
    {
        player = this;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
