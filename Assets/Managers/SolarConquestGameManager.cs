using SolarConquest;
using SoverignParticles;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SolarConquestGameManager : MonoBehaviour
{
    public SolarConquestModel UnityModel;
    public SolarConquestGame SolarConquestModel = new SolarConquestWesGame();

    void Start()
    {
        Debug.Log(SolarConquestModel.MainPlayer);
    }

    void Update()
    {
        
    }
}
