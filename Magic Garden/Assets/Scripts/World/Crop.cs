using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Crop
{
    public ResourceType ResourceType;
    public readonly int Level;
    public readonly Vector2Int GridCoords;
    public readonly Tile EarlyTile;
    public readonly Tile LateTile;

    public float StartTime;
    public readonly float GrowTime;

    public bool Ripened = false;
    public Crop(Tile earlyTile, Tile lateTile, float growTime, int level, ResourceType resourceType)
    {
        this.EarlyTile = earlyTile;
        this.LateTile = lateTile;
        this.GrowTime = growTime;
        this.Level = level;
        this.ResourceType = resourceType;
    }
    public Crop(Tile earlyTile, Tile lateTile, float growTime, int level, ResourceType resourceType, Vector2Int gridCoords)
    {
        this.EarlyTile = earlyTile;
        this.LateTile = lateTile;
        this.GrowTime = growTime;
        this.GridCoords = gridCoords;
        this.Level = level;
        this.ResourceType = resourceType;
    }
    public void Ripen()
    {
        if (Ripened) return;
        Ripened = true;
        WorldGeneration.worldGen.cropTileMap.SetTile((Vector3Int)GridCoords, LateTile);
    }
}
