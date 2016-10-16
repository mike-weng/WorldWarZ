using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WinSceneScript : MonoBehaviour {

	public Text score;
	public Text won;
	private int yourScore = 500;
	// Use this for initialization
	void Start () {
		score = GetComponent<Text> ();
		score.text = "SCORE: " + yourScore;
		won.text = "CONGRATULATIONS! YOU SURVIVED THE ZOMBIE INVASION";

	}


	public void Score(){
		
	}
}
