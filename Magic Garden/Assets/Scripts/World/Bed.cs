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
    public static void RenderBeds(Vector2Int gridCoord)
    {
        List<Bed> beds = WorldGeneration.worldGen.beds;
        Vector2Int right = new Vector2Int(gridCoord.x + 1, gridCoord.y);
        Vector2Int left = new Vector2Int(gridCoord.x - 1, gridCoord.y);
        Vector2Int up = new Vector2Int(gridCoord.x, gridCoord.y + 1);
        Vector2Int down = new Vector2Int(gridCoord.x, gridCoord.y - 1);
        Vector2Int downRight = new Vector2Int(gridCoord.x + 1, gridCoord.y - 1);
        Vector2Int downLeft = new Vector2Int(gridCoord.x - 1, gridCoord.y - 1);
        Vector2Int upLeft = new Vector2Int(gridCoord.x - 1, gridCoord.y + 1);
        Vector2Int upRight = new Vector2Int(gridCoord.x + 1, gridCoord.y + 1);

        RenderBed(gridCoord, beds);
        RenderBed(right, beds);
        RenderBed(left, beds);
        RenderBed(down, beds);
        RenderBed(up, beds);
        RenderBed(downRight, beds);
        RenderBed(downLeft, beds);
        RenderBed(upLeft, beds);
        RenderBed(upRight, beds);
    }
    private static void RenderBed(Vector2Int gridCoord, List<Bed> beds)
    {
        if (beds.Find(x => x.GridCoordinates == gridCoord) == null) return;

        Vector2Int right = new Vector2Int(gridCoord.x + 1, gridCoord.y);
        Vector2Int left = new Vector2Int(gridCoord.x - 1, gridCoord.y);
        Vector2Int up = new Vector2Int(gridCoord.x, gridCoord.y + 1);
        Vector2Int down = new Vector2Int(gridCoord.x, gridCoord.y - 1);
        Vector2Int downRight = new Vector2Int(gridCoord.x + 1, gridCoord.y - 1);
        Vector2Int downLeft = new Vector2Int(gridCoord.x - 1, gridCoord.y - 1);
        Vector2Int upLeft = new Vector2Int(gridCoord.x - 1, gridCoord.y + 1);
        Vector2Int upRight = new Vector2Int(gridCoord.x + 1, gridCoord.y + 1);

        bool rightBed = beds.Find(x => x.GridCoordinates == right) == null ? false : true;
        bool upBed = beds.Find(x => x.GridCoordinates == up) == null ? false : true;
        bool leftBed = beds.Find(x => x.GridCoordinates == left) == null ? false : true;
        bool downBed = beds.Find(x => x.GridCoordinates == down) == null ? false : true;
        bool downRightBed = beds.Find(x => x.GridCoordinates == downRight) == null ? false : true;
        bool downLeftBed = beds.Find(x => x.GridCoordinates == downLeft) == null ? false : true;
        bool upLeftBed = beds.Find(x => x.GridCoordinates == upLeft) == null ? false : true;
        bool upRightBed = beds.Find(x => x.GridCoordinates == upRight) == null ? false : true;

        if (!rightBed && !leftBed && !upBed && !downBed) WorldGeneration.worldGen.groundTileMap.SetTile((Vector3Int)gridCoord, WorldVariables.BedCenter);
        else if (rightBed && leftBed && !upBed && !downBed) WorldGeneration.worldGen.groundTileMap.SetTile((Vector3Int)gridCoord, WorldVariables.BedHorizontal);
        else if (!rightBed && !leftBed && upBed && downBed) WorldGeneration.worldGen.groundTileMap.SetTile((Vector3Int)gridCoord, WorldVariables.BedVertical);
        else if (rightBed && !leftBed && !upBed && !downBed) WorldGeneration.worldGen.groundTileMap.SetTile((Vector3Int)gridCoord, WorldVariables.BedLeft);
        else if (!rightBed && leftBed && !upBed && !downBed) WorldGeneration.worldGen.groundTileMap.SetTile((Vector3Int)gridCoord, WorldVariables.BedRight);
        else if (!rightBed && !leftBed && upBed && !downBed) WorldGeneration.worldGen.groundTileMap.SetTile((Vector3Int)gridCoord, WorldVariables.BedDown);
        else if (!rightBed && !leftBed && !upBed && downBed) WorldGeneration.worldGen.groundTileMap.SetTile((Vector3Int)gridCoord, WorldVariables.BedUp);
        else if (rightBed && leftBed && upBed && downBed && downLeftBed && downRightBed && upRightBed && upLeftBed) WorldGeneration.worldGen.groundTileMap.SetTile((Vector3Int)gridCoord, WorldVariables.BedCenterFull);
        else if (rightBed && leftBed && upBed && downBed) WorldGeneration.worldGen.groundTileMap.SetTile((Vector3Int)gridCoord, WorldVariables.BedCenterPart);
        else if (rightBed && leftBed && !upBed && downBed && downLeftBed && downRightBed) WorldGeneration.worldGen.groundTileMap.SetTile((Vector3Int)gridCoord, WorldVariables.BedThreeDownFull);
        else if (rightBed && leftBed && !upBed && downBed) WorldGeneration.worldGen.groundTileMap.SetTile((Vector3Int)gridCoord, WorldVariables.BedThreeDownPart);
        else if (rightBed && leftBed && upBed && !downBed && upLeftBed && upRightBed) WorldGeneration.worldGen.groundTileMap.SetTile((Vector3Int)gridCoord, WorldVariables.BedThreeUpFull);
        else if (rightBed && leftBed && upBed && !downBed) WorldGeneration.worldGen.groundTileMap.SetTile((Vector3Int)gridCoord, WorldVariables.BedThreeUpPart);
        else if (rightBed && !leftBed && upBed && downBed && upRightBed && downRightBed) WorldGeneration.worldGen.groundTileMap.SetTile((Vector3Int)gridCoord, WorldVariables.BedThreeRightFull);
        else if (rightBed && !leftBed && upBed && downBed) WorldGeneration.worldGen.groundTileMap.SetTile((Vector3Int)gridCoord, WorldVariables.BedThreeRightPart);
        else if (!rightBed && leftBed && upBed && downBed && upLeftBed && downLeftBed) WorldGeneration.worldGen.groundTileMap.SetTile((Vector3Int)gridCoord, WorldVariables.BedThreeLeftFull);
        else if (!rightBed && leftBed && upBed && downBed) WorldGeneration.worldGen.groundTileMap.SetTile((Vector3Int)gridCoord, WorldVariables.BedThreeLeftPart);
        else if (rightBed && !leftBed && upBed && !downBed) WorldGeneration.worldGen.groundTileMap.SetTile((Vector3Int)gridCoord, WorldVariables.BedDownLeft);
        else if (!rightBed && leftBed && upBed && !downBed) WorldGeneration.worldGen.groundTileMap.SetTile((Vector3Int)gridCoord, WorldVariables.BedDownRight);
        else if (rightBed && !leftBed && !upBed && downBed) WorldGeneration.worldGen.groundTileMap.SetTile((Vector3Int)gridCoord, WorldVariables.BedUpLeft);
        else if (!rightBed && leftBed && !upBed && downBed) WorldGeneration.worldGen.groundTileMap.SetTile((Vector3Int)gridCoord, WorldVariables.BedUpRight);
    }
}
