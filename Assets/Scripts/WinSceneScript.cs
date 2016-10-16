using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinSceneScript : MonoBehaviour {

	public Text score;
	public Text won;
	float timer =0;
	// Use this for initialization
	void Start () {
		score = GetComponent<Text> ();
		score.text = "SCORE: " + FindObjectOfType<GameManager> ().numKills; ;
		won.text = "CONGRATULATIONS! YOU SURVIVED THE ZOMBIE INVASION";
		PlayerCharacter character = FindObjectOfType<PlayerCharacter> ();
		character.GetComponent<Animator> ().SetTrigger ("Win");



	}


	void Update(){
		timer += Time.deltaTime;

		if (timer >= 5.0f) {
			SceneManager.LoadScene ("MenuScene");
		}
	}
}
