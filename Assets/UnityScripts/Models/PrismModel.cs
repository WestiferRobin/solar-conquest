using UnityEngine;
using System.Collections;
using System;


public class PrismModel : MonoBehaviour
{
	//public Prism Prism;
	public Color PrimaryColor = Color.white;
	public Color SecondaryColor = Color.gray;
    public BaseBoard Board;

    void Start()
    {
        var board = GameObject.FindGameObjectWithTag("Grid");
        Board = board.GetComponent<BaseBoard>();
        //this.Prism = new Prism();
        var cubeRenderer = gameObject.GetComponent<SpriteRenderer>();
        cubeRenderer.material.SetColor("_Color", PrimaryColor);
    }

    internal void ClearSelectedGrid()
    {
        Debug.Log("TODO: PrismModel.ClearSelectedGrid");
    }

    internal void ShowSelectedGrid()
    {
        var origin = new Vector2(transform.position.x, transform.position.y);
        var tilemap = Board.GetTilemap();

        //var hits = Physics2D.RaycastAll(origin, Vector2.zero, 0f);
        //var hits = Physics2D.RaycastAll(origin, Vector2.one, 4);
        //var tilemap = hits
    }


	// Update is called once per frame
	void Update()
	{
       
    }
}

