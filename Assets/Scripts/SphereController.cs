using UnityEngine;
using System.Collections;

public class SphereController : MonoBehaviour {
	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
    }

    void FixedUpdate() {
        GetComponent<Rigidbody>().AddForce(Input.acceleration.x * 5.0f, 0, -Input.acceleration.z * 5.0f);
    }

    void OnCollisionEnter(Collision col) {
        GameObject characterObject = col.gameObject;
        ZombieCharacter characterComponent = characterObject.GetComponent<ZombieCharacter>();
        if (characterComponent)
        {
            characterComponent.TakeImpact();
            characterObject.GetComponent<Health>().DecreaseHealth(200.0f);
        }
    }
}
