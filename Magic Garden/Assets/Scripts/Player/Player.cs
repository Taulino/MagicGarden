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

    public bool[] isFull;
    public GameObject[] resources;
    public GameObject[] slots;
    public ItemData item;

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
    public void AddItem()
    {
        for (int i = 0; i < slots.Length; i++)
        {
            if (isFull[i] == false)
            {
               Instantiate(resources[i], slots[i].transform.position,Quaternion.identity);
                isFull[i] = true;
                break;
            }
        }
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Item")
        {
            
        }
    }

}
