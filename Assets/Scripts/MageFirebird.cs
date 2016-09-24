using UnityEngine;
using System.Collections;

public class MageFirebird : Skill {
	private Animator animator;
	private ParticleSystem skill1ParticleSystem;
	private GameObject collidedCharacter;
	public GameObject bleedEffect;
	private float damage = 200.0f;


	// Use this for initialization
	void Start () {
		animator = GetComponentInParent<Animator> ();
		skill1ParticleSystem = GetComponent<ParticleSystem> ();
	}

	// Update is called once per frame
	void Update () {

	}

	public override void HandlePhysics() {
		skill1ParticleSystem.GetComponent<SphereCollider> ().enabled = true;
	}

	public override void UpdateAnimator () {
		print ("Update animator skill1");
		animator.SetTrigger("Skill1");
		skill1ParticleSystem.Play ();
		Invoke ("DisableCollision", skill1ParticleSystem.startLifetime);
	}

	void DisableCollision() {
		skill1ParticleSystem.GetComponent<SphereCollider> ().enabled = false;
	}

	void OnTriggerEnter(Collider collider) {
		GameObject collidedCharacter = collider.gameObject;
		PlayerCharacter character = collidedCharacter.GetComponent<PlayerCharacter> ();
		if (character) {
			this.collidedCharacter = collidedCharacter;
			collidedCharacter.GetComponent<Health> ().DecreaseHealth (damage);
			GameObject statusEffect = Instantiate (bleedEffect);
			statusEffect.transform.parent = collidedCharacter.transform;
			character.addStatusEffect (statusEffect);
			Invoke ("PushBack", 0.3f);
		}
	}

	void PushBack() {
		Rigidbody rigidBody = collidedCharacter.GetComponent<Rigidbody> ();
		rigidBody.AddForce ((collidedCharacter.transform.position - transform.position) * 5000f);
	}
}
