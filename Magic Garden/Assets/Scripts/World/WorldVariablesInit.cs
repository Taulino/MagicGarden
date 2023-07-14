using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class WorldVariablesInit : MonoBehaviour
{
    public Tile earlyWheatTile;
    public Tile lateWheatTile;
    public Crop wheatCrop;
    public Tile bedTile;
    [Header("Fence")]
    public Tile fenceHorizontal;
    public Tile fenceVertical;
    public Tile fenceRight;
    public Tile fenceLeft;
    public Tile fenceUp;
    public Tile fenceDown;
    public Tile fenceDownRight;
    public Tile fenceDownLeft;
   

    void Awake()
    {
        WorldVariables.WheatCrop = new Crop(earlyWheatTile,lateWheatTile, 10, 1, ResourceType.Crop);
        WorldVariables.BedTile = bedTile;


    }
}
