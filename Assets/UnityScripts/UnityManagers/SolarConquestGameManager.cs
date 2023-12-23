using SolarConquestGameModels;
using SoverignParticles;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SolarConquestGameManager : MonoBehaviour
{
    //public SolarConquestModel UnityModel;
    //public SolarConquestGame SolarConquestModel = new SolarConquestWesGame();
    private GameSystem system = new LevithanGameSystem();

    void Start()
    {
        Debug.Log(system.Owner.Name);
    }

    void Update()
    {
    }
}
