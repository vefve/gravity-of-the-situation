using UnityEngine;
using System.Collections.Generic;

public class SceneMaps {
	private Transform WallPrefab;
	private List<Transform>[,] CurrentScene;
	private int length;
	private int height;
	public SceneMaps(int length, int height, Transform wallPrefab) {
		this.length = length;
		this.height = height;
        this.WallPrefab = wallPrefab;
		CurrentScene = new List<Transform>[length, height];
		for (int i = 0; i < length; i++)
		{
			for (int j = 0; j < height; j++)
			{
				CurrentScene[i, j] = null;
			}
		}
	}
		
	public List<Transform>[,] getScene1 () {
		List<Transform>[,] CurrentScene = new List<Transform>[length, height];
		for (var x = 0; x < 16; x++) {
			for (var y = 0; y < 16; y++) {
				CurrentScene[x,y] = new List<Transform>(new Transform[] { WallPrefab });
			}
		}
		return CurrentScene;
	}
}
