using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fence
{
    public Vector2Int GridCoordinates;
    public Fence(Vector2Int gridCoordinates)
    {
        this.GridCoordinates = gridCoordinates;
    }
    public static void RenderFence(Vector2Int gridCoord)
    {
        List<Fence> fences = WorldGeneration.worldGen.fences;

    }
}
