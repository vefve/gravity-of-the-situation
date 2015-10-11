using UnityEngine;
using System.Collections.Generic;

public class SceneMaps {
	private Transform WallPrefab;
	private Transform SpikesTopPrefab;
	private List<Transform>[,] CurrentScene;
	private int length;
	private int height;
	public SceneMaps(int length, int height, Transform wallPrefab, Transform spikesTopPrefab) {
		this.length = length;
		this.height = height;
        this.WallPrefab = wallPrefab;
		this.SpikesTopPrefab = spikesTopPrefab;
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
				if (x == 0 || x == 15 || y == 0 || y == 15)
					CurrentScene[x,y] = new List<Transform>(new Transform[] { WallPrefab });
			}
		}
		
		int i;
		int j;
		
		for (i = 1, j = 3; i < 6; i++) {
			CurrentScene[i,j] = new List<Transform>(new Transform[] { WallPrefab });
		}

		for (i = 1, j = 11; i < 7; i++) {
			CurrentScene[i,j] = new List<Transform>(new Transform[] { WallPrefab });
		}
		
		for (i = 14, j = 7; i > 9; i--) {
			CurrentScene[i,j] = new List<Transform>(new Transform[] { WallPrefab });
		}
		
		for (i = 11, j = 1; j < 4; j++) {
			CurrentScene[i,j] = new List<Transform>(new Transform[] { WallPrefab });
		}
		CurrentScene[i,j] = new List<Transform>(new Transform[] { SpikesTopPrefab });
		return CurrentScene;
	}
}
