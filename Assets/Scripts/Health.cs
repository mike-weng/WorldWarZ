using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {
	public float health = 100.0f;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void DecreaseHealth(float value) {
		health -= value;
		print ("decrease: " + health);
		if (health <= 0) {
			DestroyObject ();
		}
	}

	public void DestroyObject() {
		Destroy (gameObject);
	}
}
