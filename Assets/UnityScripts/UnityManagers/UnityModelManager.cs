using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolarConquestGameModels;
using UnityEngine;
using UnityEngine.Tilemaps;

public class UnityModelManager : MonoBehaviour
{
    private SolarConquestGameManager GameManager;

    public TileBase baseTile;
    public TileBase eventTile;
    public TileBase grassTile;
    public TileBase highlightTile; // The highlight Tile to use
    public TileBase wallTile;
    public TileBase waterTile;
    private Tilemap tilemap; // Reference to your Tilemap


    // Start is called before the first frame update
    void Start()
    {
        if (gameObject.TryGetComponent<SolarConquestGameManager>(out var manager))
        {
            this.GameManager = manager;
            ConfigureTilemap();
        }
        else throw new Exception("UNITY MODEL MANAGER IS BROKEN!");
    }

    private void ConfigureTilemap()
    {
        var masterGrid = GameObject.FindGameObjectsWithTag("Grid");
        var map = masterGrid.Where(x => x.GetComponent<Tilemap>()).First();
        if (map.name == UnityTags.MasterTileMap)
        {
            this.tilemap = map.GetComponent<Tilemap>();
            LinkBoardToTilemap(GameManager.SolarConquest.Board);
        }
        else throw new Exception("CANT FIND THE MASTER BOARD!");

    }

    private void LinkBoardToTilemap(IBoard board)
    {
        Stack<Stack<IBoardItem>> lines = new();
        foreach (var line in board.GetLines())
        {
            var lineItems = new Stack<IBoardItem>();
            foreach (var item in line.GetLineItems())
            {
                Debug.Log(item);
                lineItems.Push(item);
            }
            lines.Push(lineItems);
        }

        int y = 0;
        while (lines.Any())
        {
            var line = lines.Pop();

            int x = 0;
            while (line.Any())
            {
                //var item = line.Pop();
                this.tilemap.SetTile(
                    new Vector3Int(x, y),
                    baseTile
                );
                x++;
            }

            y++;
        }
    }

    void Update()
    {
        var status = this.GameManager.SolarConquest.IsRunning() ? "ALIVE" : "DEAD";
        var message = $"Solar Conquest Game is: {status}";
        Debug.Log(message);
        // Read from the data model of SolarConquest
        // Will need to do this for tiles and other shit
        // Anyways main idea is that Unity visualise our data
        // That data will handle encounters
        // This game must have a strong mod support
        // BECAUSE we can make openai services
        // For rapid prototyping and test data generation
        // We can create ai generated random events and shit
        // FUCKING RANDOM FUN CREATIVE AND EXCITING
    }
}
