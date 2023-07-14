using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class WorldVariablesInit : MonoBehaviour
{
    public Tile earlyWheatTile;
    public Tile lateWheatTile;

    public Tile bedTile;

    public Crop wheatCrop;

    void Awake()
    {
        WorldVariables.WheatCrop = new Crop(earlyWheatTile,lateWheatTile, 10, 1, ResourceType.Crop);
        WorldVariables.BedTile = bedTile;
    }
}
