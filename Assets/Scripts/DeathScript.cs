﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class DeathScript : MonoBehaviour {


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y <= -10) {
			SceneManager.LoadScene ("LoseScene");
		}
	}


}
