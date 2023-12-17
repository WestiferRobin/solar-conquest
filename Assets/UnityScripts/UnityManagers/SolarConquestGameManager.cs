using Assets.SoverignParticles.Components;
using SolarConquestGameModels;
using SoverignParticles;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SolarConquestGameManager : MonoBehaviour
{
    public SolarConquestModel UnityModel;
    public SolarConquestGame SolarConquestModel = new SolarConquestWesGame();

    public static ISystem SolarSystem;
    public static ISystem GameSystem;


    void Start()
    {

    }

    void Update()
    {
    }
}
