using UnityEngine;
using System.Collections.Generic;
//using Assets.Scripts;

public class SceneManager : MonoBehaviour {
    public List<Transform>[,] sceneMap;
    public Transform WallPrefab;
    public GameObject PlayerCharacterPrefab;
    public GameObject PlayerCharacterReference;
    public Vector3 LevelSpawnPoint;
    public int MapLength = 16;
    public int MapHeight = 16;
    private float scalingFactor = 0.8f;
	// Use this for initialization
	void Start () {
        sceneMap = new SceneMaps(MapLength, MapHeight).getScene1();
        for (int x = 0; x < MapLength; x++)
        {
            for (int y = 0; y < MapHeight; y++)
            {
                if (sceneMap[x, y] != null) {
                    Instantiate(sceneMap[x,y][1], new Vector3(x * scalingFactor, y * scalingFactor, 0), Quaternion.identity);
                }
            }
        }

        PlayerCharacterReference = (GameObject)Instantiate(PlayerCharacterPrefab, LevelSpawnPoint, new Quaternion());
	}
	
	// Update is called once per frame
	void Update () {
	    
	}
}
