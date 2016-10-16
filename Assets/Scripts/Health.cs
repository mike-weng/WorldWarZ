using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public float health = 100.0f;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void DecreaseHealth(float value)
    {
        health -= value;
        print("decrease: " + health);
        if (health <= 0)
        {
			Character character = GetComponent<Character>();
			character.Die();
			if (GetComponent<PlayerCharacter> ()) {
				// load scenes
				Invoke("LoadWinScene", 3.0f);
			}

        }
    }

	void LoadWinScene() {
		SceneManager.LoadScene ("WinScene");

	}

    public void IncreaseHealth(float value)
    {
        health += value;
        print("increase: " + health);
    }

    public void DestroyObject()
    {
        Destroy(gameObject);
    }
}

