﻿using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D collision) {
		Debug.Log("Lo");
		if(collision.gameObject.tag == "Player") {
			Destroy(collision.gameObject);
		}
	}
}
