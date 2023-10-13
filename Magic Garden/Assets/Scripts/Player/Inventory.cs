using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public ItemData item;
    public bool[] isFull;
    public GameObject[] slot;
    public GameObject Player;
    public Collider2D collider;
    void Start()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (this.gameObject.CompareTag("ItemTag")) 
        {
            Debug.Log("fdsf");
        }
    }
}
