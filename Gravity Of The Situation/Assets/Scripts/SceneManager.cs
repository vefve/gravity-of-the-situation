using UnityEngine;
using System.Collections;
using Assets.Scripts;

public class SceneManager : MonoBehaviour {
    public TileMap TileMap;
    public Transform WallPrefab;
    public int MapLength = 32;
    public int MapHeight = 32;
	// Use this for initialization
	void Start () {
        TileMap = new TileMap(MapLength, MapHeight);
        for (int i = 0; i < MapLength; i++)
        {
            for (int j = 0; j < MapHeight; j++)
            {
                
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
