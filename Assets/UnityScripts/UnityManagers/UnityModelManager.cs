using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class UnityModelManager : MonoBehaviour
{
    private SolarConquestGameManager GameManager;


    // Start is called before the first frame update
    void Start()
    {
        if (gameObject.TryGetComponent<SolarConquestGameManager>(out var manager))
        {
            this.GameManager = manager;
            //this.UnityModel = this.GameManager.UnityModel;
        }
        else throw new Exception("UNITY MODEL MANAGER IS BROKEN!");
    }

    void Update()
    {
    }
}
