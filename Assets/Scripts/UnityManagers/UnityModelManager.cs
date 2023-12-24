using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            this.tilemap = GetComponent<Tilemap>();

            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 5; x++)
                {
                    this.tilemap.SetTile(
                        new Vector3Int(x, y),
                        baseTile
                    );
                }
            }
        }
        else throw new Exception("UNITY MODEL MANAGER IS BROKEN!");
    }

    void Update()
    {

        var gameBoard = GameManager.SolarConquest.Board;

        foreach (var line in gameBoard.GetLines())
        {
            foreach (var item in line.GetLineItems())
            {
                Debug.Log(item);
            }
        }

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
