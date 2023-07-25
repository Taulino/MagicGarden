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
    public static void RenderFences(Vector2Int gridCoord)
    {
        List<Fence> fences = WorldGeneration.worldGen.fences;
        Vector2Int right = new Vector2Int(gridCoord.x + 1, gridCoord.y);
        Vector2Int left = new Vector2Int(gridCoord.x - 1, gridCoord.y);
        Vector2Int up = new Vector2Int(gridCoord.x, gridCoord.y + 1);
        Vector2Int down = new Vector2Int(gridCoord.x, gridCoord.y -1);

        RenderFence(gridCoord, fences);
        RenderFence(right, fences);
        RenderFence(left, fences);
        RenderFence(down, fences);
        RenderFence(up, fences);
    }
    private static void RenderFence(Vector2Int gridCoord, List<Fence> fences)
    {
        if (fences.Find(x => x.GridCoordinates == gridCoord) == null) return;

        Vector2Int right = new Vector2Int(gridCoord.x + 1, gridCoord.y);
        Vector2Int left = new Vector2Int(gridCoord.x - 1, gridCoord.y);
        Vector2Int up = new Vector2Int(gridCoord.x, gridCoord.y + 1);
        Vector2Int down = new Vector2Int(gridCoord.x, gridCoord.y - 1);
        Vector2Int downRight = new Vector2Int(gridCoord.x + 1, gridCoord.y - 1);
        Vector2Int downLeft = new Vector2Int(gridCoord.x - 1, gridCoord.y - 1);
        Vector2Int upLeft = new Vector2Int(gridCoord.x - 1 , gridCoord.y + 1);
        Vector2Int upRight = new Vector2Int(gridCoord.x + 1, gridCoord.y + 1);
        bool rightFence = fences.Find(x => x.GridCoordinates == right) == null ? false : true;
        bool upFence = fences.Find(x => x.GridCoordinates == up) == null ? false : true;
        bool leftFence = fences.Find(x => x.GridCoordinates == left) == null ? false : true;
        bool downFence = fences.Find(x => x.GridCoordinates == down) == null ? false : true;
        bool downRightFence = fences.Find(x => x.GridCoordinates == downRight) == null ? false : true;
        bool downLeftFence = fences.Find(x => x.GridCoordinates == downLeft) == null ? false : true;
        bool upLeftFence = fences.Find(x => x.GridCoordinates == upLeft) == null ? false : true;
        bool upRightFence = fences.Find(x => x.GridCoordinates == upRight) == null ? false : true;

        if (rightFence && leftFence && upFence && downFence) WorldGeneration.worldGen.buildingTileMap.SetTile((Vector3Int)gridCoord, WorldVariables.FenceCenter);
        else if (!rightFence && !leftFence && !upFence && !downFence) WorldGeneration.worldGen.buildingTileMap.SetTile((Vector3Int)gridCoord, WorldVariables.FenceHorizontal);
        else if (rightFence && leftFence && !upFence && !downFence) WorldGeneration.worldGen.buildingTileMap.SetTile((Vector3Int)gridCoord, WorldVariables.FenceHorizontal);
        else if (downFence && upFence && !rightFence && !leftFence && !upRightFence && !downRightFence) WorldGeneration.worldGen.buildingTileMap.SetTile((Vector3Int)gridCoord, WorldVariables.FenceVertical2);
        else if (leftFence && !rightFence && !upFence && !downFence) WorldGeneration.worldGen.buildingTileMap.SetTile((Vector3Int)gridCoord, WorldVariables.FenceRight);
        else if (rightFence && !leftFence && !upFence && !downFence) WorldGeneration.worldGen.buildingTileMap.SetTile((Vector3Int)gridCoord, WorldVariables.FenceLeft);
        else if (rightFence && !leftFence && upFence && downFence) WorldGeneration.worldGen.buildingTileMap.SetTile((Vector3Int)gridCoord, WorldVariables.FenceThreeRight);
        else if (!rightFence && leftFence && upFence && downFence) WorldGeneration.worldGen.buildingTileMap.SetTile((Vector3Int)gridCoord, WorldVariables.FenceThreeLeft);
        else if (rightFence && leftFence && !upFence && downFence) WorldGeneration.worldGen.buildingTileMap.SetTile((Vector3Int)gridCoord, WorldVariables.FenceThreeDown);
        else if (rightFence && leftFence && upFence && !downFence) WorldGeneration.worldGen.buildingTileMap.SetTile((Vector3Int)gridCoord, WorldVariables.FenceCenter);
        else if (!rightFence && leftFence && upFence && !downFence) WorldGeneration.worldGen.buildingTileMap.SetTile((Vector3Int)gridCoord, WorldVariables.FenceDownRight);
        else if (rightFence && !leftFence && upFence && !downFence) WorldGeneration.worldGen.buildingTileMap.SetTile((Vector3Int)gridCoord, WorldVariables.FenceDownLeft);
        else if (!rightFence && leftFence && !upFence && downFence) WorldGeneration.worldGen.buildingTileMap.SetTile((Vector3Int)gridCoord, WorldVariables.FenceRight);
        else if (rightFence && !leftFence && !upFence && downFence) WorldGeneration.worldGen.buildingTileMap.SetTile((Vector3Int)gridCoord, WorldVariables.FenceLeft);
        else if(upFence && upRightFence && upLeftFence) WorldGeneration.worldGen.buildingTileMap.SetTile((Vector3Int)gridCoord, WorldVariables.FenceVertical2);
        else if (downFence && downRightFence && downLeftFence) WorldGeneration.worldGen.buildingTileMap.SetTile((Vector3Int)gridCoord, WorldVariables.FenceVertical2);
        else if (!rightFence && !leftFence && upFence && !downFence) WorldGeneration.worldGen.buildingTileMap.SetTile((Vector3Int)gridCoord, WorldVariables.FenceVertical2);
        else if (!rightFence && !leftFence && !upFence && downFence) WorldGeneration.worldGen.buildingTileMap.SetTile((Vector3Int)gridCoord, WorldVariables.FenceVertical2);
        else if (upFence && downFence) WorldGeneration.worldGen.buildingTileMap.SetTile((Vector3Int)gridCoord, WorldVariables.FenceVertical2);
        
    }
}
