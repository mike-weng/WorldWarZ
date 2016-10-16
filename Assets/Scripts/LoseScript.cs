using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoseScript : MonoBehaviour {

	public Text score;
	public Text lose;
	float timer =0;
	// Use this for initialization
	void Start () {
		score = GetComponent<Text> ();
		score.text = "SCORE: " + FindObjectOfType<GameManager> ().numKills; ;
		lose.text = "YOU LOSE! THE ZOMBIES ARE TAKING OVER THE WORLD";
		PlayerCharacter character = FindObjectOfType<PlayerCharacter> ();
		character.GetComponent<Animator> ().SetTrigger ("Die");



	}


	void Update(){
		timer += Time.deltaTime;

		if (timer >= 8.0f) {
			SceneManager.LoadScene ("MenuScene");
		}
	}
}
