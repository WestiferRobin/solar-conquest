using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolarConquestGameModels;
using Unity.Collections.LowLevel.Unsafe;
using UnityEditor;
using UnityEngine;
using UnityEngine.Tilemaps;
using static UnityEditor.PlayerSettings;
using SoverignParticles;

public class UnityModelManager : MonoBehaviour
{
    private SolarConquestGameManager GameManager;


    public TileBase whiteTile;
    public TileBase yellowTile;
    public TileBase redTile;
    public TileBase greenTile;
    public TileBase blueTile;

    public TileBase blackTile;
    public TileBase purpleTile;
    public TileBase cyanTile;
    public TileBase magentaTile;
    public TileBase orangeTile;

    public TileBase greyTile;
    public TileBase pinkTile;

    private Tilemap tileMap; // Reference to your Tilemap


    // Start is called before the first frame update
    void Start()
    {
        if (gameObject.TryGetComponent<SolarConquestGameManager>(out var manager))
        {
            this.GameManager = manager;
            this.GameManager.LevithanSystem = new LevithanGameSystem();
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
            this.tileMap = map.GetComponent<Tilemap>();
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
                var item = line.Pop();
                if (item is GameBoardItem<SolarSystem>)
                {
                    var gameItem = (GameBoardItem<SolarSystem>) item;
                    var solarSystem = gameItem.Model;

                    var asdf = solarSystem.InnerPlanets;
                    var fdsa = solarSystem.OuterPlanets;

                    TileBase tile;
                    switch (solarSystem.ParticleID)
                    {
                        case Particle.Omega:
                            tile = blackTile;
                            break;
                        case Particle.Delta:
                            tile = whiteTile;
                            break;
                        case Particle.Theta:
                            tile = cyanTile;
                            break;
                        case Particle.Phi:
                            tile = magentaTile;
                            break;
                        case Particle.Lambda:
                            tile = yellowTile;
                            break;
                        case Particle.Sigma:
                            tile = orangeTile;
                            break;
                        case Particle.Epsilon:
                            tile = pinkTile;
                            break;
                        case Particle.Mu:
                            tile = greyTile;
                            break;
                        case Particle.Psi:
                            tile = purpleTile;
                            break;
                        case Particle.Alpha:
                            tile = redTile;
                            break;
                        case Particle.Gamma:
                            tile = greenTile;
                            break;
                        case Particle.Beta:
                            tile = blueTile;
                            break;
                        default:
                            throw new Exception(
                                $"NO PARTICLE FOUND FOR TILE {solarSystem.ParticleID}"
                            );
                    }

                    // Measures Planet count
                    //if (asdf.Count == 3 && fdsa.Count == 3)
                    //{
                    //    tile = greenTile;
                    //}
                    //else if(asdf.Count == 2 && fdsa.Count == 2)
                    //{
                    //    tile = cyanTile;
                    //}
                    //else if (asdf.Count == 1 && fdsa.Count == 1)
                    //{
                    //    tile = magentaTile;
                    //}
                    //else if (asdf.Count == 0 && fdsa.Count == 0)
                    //{
                    //    tile = redTile;
                    //}
                    //else if (asdf.Count > 0 && fdsa.Count == 0)
                    //{
                    //    tile = yellowTile;
                    //}
                    //else if (fdsa.Count > 0 && asdf.Count == 0)
                    //{
                    //    tile = blueTile;
                    //}
                    //else
                    //{
                    //    tile = greyTile;
                    //}
                    this.tileMap.SetTile(
                        new Vector3Int(x, y),
                        tile
                    );
                }
                else
                {
                    this.tileMap.SetTile(
                        new Vector3Int(x, y),
                        greyTile
                    );
                }
                x++;
            }

            y++;
        }
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3Int coordinate = tileMap.WorldToCell(mouseWorldPos);
            var tile = tileMap.GetTile(coordinate);
            Debug.Log(tile.name);
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
