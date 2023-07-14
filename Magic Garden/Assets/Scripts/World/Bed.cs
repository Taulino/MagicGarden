using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bed 
{
    public Crop Crop;
    public Vector2Int GridCoordinates;

    public Bed(Vector2Int gridCoordinates)
    {
        GridCoordinates = gridCoordinates;
    }
}
