﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    public float numKills = 0;
    private float timePast = 0;
    public float timeLimit = 300.0f;
    // Use this for initialization
    void Start () {
		DontDestroyOnLoad (this);
		Slider timeSlider = GameObject.Find ("TimeSlider").GetComponent<Slider>();
        timeSlider.maxValue = timeLimit;
    }

    // Update is called once per frame
    void Update () {
        timePast += Time.deltaTime;
		Slider timeSlider = GameObject.Find ("TimeSlider").GetComponent<Slider>();
        timeSlider.value = timePast;
		float score = FindObjectOfType<GameManager> ().numKills;

		if (timePast >= timeLimit)
        {
			if (score >= 50) {
				//load scene
				SceneManager.LoadScene("WinScene");
			} else {
				//load scene
				SceneManager.LoadScene("LoseScene");
			}
        }
    }

    public void AddNumKills() {
        this.numKills = this.numKills + 1;
        GameObject scoreObject = GameObject.Find("NumKills");
        Text scoreText = scoreObject.GetComponent<Text>();
        scoreText.text = "Score: " + numKills;
    }
}
