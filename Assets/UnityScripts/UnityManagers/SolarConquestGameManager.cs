using Levithan;
using SolarConquestGameModels;
using SoverignParticles;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class SolarConquestGameManager : MonoBehaviour
{
    public GameSystem LevithanSystem;
    public IGame SolarConquest;

    public Particle PrismID = Particle.Omega;

    void Start()
    {
        LevithanSystem = new LevithanGameSystem();
        //SolarConquest = LevithanSystem.Game;
        //LevithanSystem.StartGame();
    }

    void Update()
    {
        // This is where our controller affects the game model
        //if (Input.GetKeyDown(KeyCode.Tab)) Debug.Log($"Using Prism: {PrismID}");
    }
}
