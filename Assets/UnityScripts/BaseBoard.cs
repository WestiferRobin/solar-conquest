using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class BaseBoard : MonoBehaviour
{

    // NOTE: THIS IS THE TILE PALLETE STUFF
    public TileBase baseTile;
    public TileBase eventTile;
    public TileBase grassTile;
    public TileBase highlightTile; // The highlight Tile to use
    public TileBase wallTile;
    public TileBase waterTile;


    private TileBase previousTile;
    private Vector3Int previousTileCoordinate;
    private Tilemap tilemap; // Reference to your Tilemap

    public Tilemap GetTilemap() { return tilemap; }

    private void Awake()
    {
        tilemap = GetComponent<Tilemap>();
        previousTile = null;
        previousTileCoordinate = Vector3Int.zero;
    }

    private void OnMouseOver()
    {
        Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3Int tileCoordinate = tilemap.WorldToCell(mouseWorldPos);

        var currentTile = tilemap.GetTile(tileCoordinate);
        currentTile.GetType();

        if (tileCoordinate != previousTileCoordinate)
        {
            if (this.previousTile == null)
            {
                this.previousTile = baseTile;
            } else
            {
                tilemap.SetTile(previousTileCoordinate, this.previousTile);
            }
            TileBase currentHighlightTile = ConfigHighlightTile(currentTile.name);
            tilemap.SetTile(tileCoordinate, currentHighlightTile);
            previousTileCoordinate = tileCoordinate;
            this.previousTile = currentTile;
        }
    }

    private TileBase ConfigHighlightTile(string name)
    {
        if (name == "WallTile") return wallTile;
        return highlightTile;
    }

    private void OnMouseExit()
    {
        tilemap.SetTile(previousTileCoordinate, this.previousTile);
    }
}
