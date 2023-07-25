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
    public Tile FenceHorizontal;
    public Tile FenceVertical;
    public Tile FenceRight;
    public Tile FenceLeft;
    public Tile FenceThreeRight;
    public Tile FenceThreeLeft;
    public Tile FenceDownRight;
    public Tile FenceDownLeft;
    public Tile FenceCenter;
    public Tile FenceVertical2;
    public Tile FenceThreeDown;

    [Header("Bed")]
    public Tile BedCenter;
    public Tile BedRight;
    public Tile BedLeft;
    public Tile BedHorizontal;
    public Tile BedVertical;
    public Tile BedUp;
    public Tile BedDown;
    public Tile BedDownRight;
    public Tile BedDownLeft;
    public Tile BedUpRight;
    public Tile BedUpLeft;
    public Tile BedCenterFull;
    public Tile BedCenterPart;
    public Tile BedThreeDownFull;
    public Tile BedThreeDownPart;
    public Tile BedThreeRightFull;
    public Tile BedThreeRightPart;
    public Tile BedThreeLeftFull;
    public Tile BedThreeLeftPart;
    public Tile BedThreeUpFull;
    public Tile BedThreeUpPart;

    void Awake()
    {
        WorldVariables.WheatCrop = new Crop(earlyWheatTile,lateWheatTile, 10, 1, ResourceType.Crop);
        WorldVariables.BedTile = bedTile;

        WorldVariables.FenceThreeDown = FenceThreeDown;
        WorldVariables.FenceHorizontal = FenceHorizontal;
        WorldVariables.FenceVertical = FenceVertical;
        WorldVariables.FenceRight = FenceRight;
        WorldVariables.FenceLeft = FenceLeft;
        WorldVariables.FenceThreeRight = FenceThreeRight;
        WorldVariables.FenceThreeLeft = FenceThreeLeft;
        WorldVariables.FenceDownRight = FenceDownRight;
        WorldVariables.FenceDownLeft = FenceDownLeft;
        WorldVariables.FenceCenter = FenceCenter;
        WorldVariables.FenceVertical2 = FenceVertical2;

        WorldVariables.BedCenter = BedCenter;
        WorldVariables.BedRight= BedRight;
        WorldVariables.BedLeft = BedLeft;
        WorldVariables.BedHorizontal = BedHorizontal;
        WorldVariables.BedVertical = BedVertical;
        WorldVariables.BedUp = BedUp;
        WorldVariables.BedDown = BedDown;
        WorldVariables.BedDownRight = BedDownRight;
        WorldVariables.BedDownLeft = BedDownLeft;
        WorldVariables.BedUpRight = BedUpRight;
        WorldVariables.BedUpLeft = BedUpLeft;
        WorldVariables.BedCenterFull = BedCenterFull;
        WorldVariables.BedCenterPart = BedCenterPart;
        WorldVariables.BedThreeDownFull = BedThreeDownFull;
        WorldVariables.BedThreeDownPart = BedThreeDownPart;
        WorldVariables.BedThreeRightFull = BedThreeRightFull;
        WorldVariables.BedThreeRightPart = BedThreeRightPart;
        WorldVariables.BedThreeLeftFull = BedThreeLeftFull;
        WorldVariables.BedThreeLeftPart = BedThreeLeftPart;
        WorldVariables.BedThreeUpFull = BedThreeUpFull;
        WorldVariables.BedThreeUpPart = BedThreeUpPart;
    }
}
