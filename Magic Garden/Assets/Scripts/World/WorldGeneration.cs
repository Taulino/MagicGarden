using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Tilemaps;

public class WorldGeneration : MonoBehaviour
{
    public Camera currentCamera;
    public Grid grid;
    public Tilemap groundTileMap;
    public Tilemap cropTileMap;
    public Tilemap buildingTileMap;

    public float time;

    public static WorldGeneration worldGen;

    public List<Crop> crops = new List<Crop>();
    public List<Bed> beds = new List<Bed>();
    public List<Fence> fences = new List<Fence>();
    void Awake()
    {
        worldGen = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3Int gridPosition = grid.WorldToCell(currentCamera.ScreenToWorldPoint(Input.mousePosition));
            PlaceCrop(WorldVariables.WheatCrop, (Vector2Int)gridPosition);
        }
        if (Input.GetMouseButtonDown(2))
        {
            Vector3Int gridPosition = grid.WorldToCell(currentCamera.ScreenToWorldPoint(Input.mousePosition));
            PlaceBed((Vector2Int)gridPosition);
        }
        if (Input.GetMouseButtonDown(1))
        {
            Vector3Int gridPosition = grid.WorldToCell(currentCamera.ScreenToWorldPoint(Input.mousePosition));
            PlaceFence((Vector2Int)gridPosition);
        }

        time += Time.deltaTime;

        CheckCrops();
    }
    public void PlaceCrop(Crop crop, Vector2Int gridPosition)
    {
        if(beds.Find(x => x.GridCoordinates == gridPosition) == null)
        {
            Debug.Log("Unable to spawn crop: no bed is present");
            return;
        }
        if(crops.Find(x => x.GridCoords == gridPosition) != null)
        {
            Debug.Log("Unable to plant new crop: it already exists on this place");
            return;
        }
        cropTileMap.SetTile((Vector3Int)gridPosition, crop.EarlyTile);
        Crop newCrop = new Crop(crop.EarlyTile, crop.LateTile, crop.GrowTime, crop.Level, crop.ResourceType, gridPosition);
        newCrop.StartTime = time;
        crops.Add(newCrop);

    }
    public void PlaceCrop(Crop crop, Vector2 worldPosition)
    {
        Vector3Int gridPosition = grid.WorldToCell(worldPosition);
        PlaceCrop(crop, (Vector2Int)gridPosition);
    }
    public void PlaceBed(Vector2Int gridPosition)
    {
        if (beds.Find(x => x.GridCoordinates == gridPosition) != null)
        {
            Debug.Log("Unable to make the bed: the place already contains it");
            return;
        }
        if(fences.Find(x => x.GridCoordinates == gridPosition) != null)
        {
            Debug.Log("Unable to place a bed: the place is taken by a fence");
            return;
        }
        beds.Add(new Bed(gridPosition));
        Bed.RenderBeds(gridPosition);
    }
    public void PlaceBed(Vector2 worldPosition)
    {
        Vector3Int gridPosition = grid.WorldToCell(worldPosition);
        PlaceBed((Vector2Int)gridPosition);
    }
    public void CheckCrops()
    {
        crops.ForEach(crop =>
        {
            if (time - crop.StartTime > crop.GrowTime && !crop.Ripened) crop.Ripen();
        });
    }
    public void Harvest(Vector2Int gridPosition)
    {
        if (crops.Find(x => x.GridCoords == gridPosition) == null)
        {
            Debug.Log("Unable to harvest the crop: the place is empty");
            return;
        }
        Crop crop = crops.Find(x => x.GridCoords == gridPosition);
        if (!crop.Ripened)
        {
            Debug.Log("Unable to harvest the crop: the crop is not ripened");
            return;
        }
        cropTileMap.SetTile((Vector3Int)gridPosition, null);
        Player.player.Resources[(int)crop.ResourceType] += 1;
        crops.Remove(crop);

    }
    public void PlaceFence(Vector2Int gridPosition)
    {

        if(fences.Find(x => x.GridCoordinates == gridPosition) != null)
        {
            Debug.Log("Unable to place the fence: the position is taken");
            return;
        }
        if(beds.Find(x => x.GridCoordinates == gridPosition) != null)
        {
            Debug.Log("Unable to place the fence: there is a bed in that position");
            return;
        }
        fences.Add(new Fence(gridPosition));
        Fence.RenderFences(gridPosition);
    }
}
