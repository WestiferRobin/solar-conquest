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
    public IGame SolarConquest => LevithanSystem.Game;

    public Particle PrismID = Particle.Omega;

    void Start()
    {
    }

    void Update()
    {
        // This is where our controller affects the game model
        if (Input.GetKeyDown(KeyCode.Tab)) Debug.Log($"Using Prism: {PrismID}");
    }
}
