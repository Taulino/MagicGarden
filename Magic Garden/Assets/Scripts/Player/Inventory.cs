using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public Player inventory;
    void Start()
    {
        inventory = GetComponent<Player>();
    }
    public void AddItem()
    {

    }
}
