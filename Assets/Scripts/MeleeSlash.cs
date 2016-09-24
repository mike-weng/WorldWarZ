using UnityEngine;
using System.Collections;

public class MeleeSlash : Skill {

	// Use this for initialization
	public override void Start () {
		base.Start ();
		base.changeInLife = 20.0f;
	}

	// Update is called once per frame
	void Update () {

	}

	public override void HandlePhysics() {
		skillCollider.enabled = true;
	}

	public override void UpdateAnimator () {
		animator.SetTrigger("Skill1");
		GetComponent<ParticleSystem>().Play ();
		Invoke ("DisableCollision", GetComponent<ParticleSystem>().startLifetime);
	}

	void DisableCollision() {
		GetComponent<ParticleSystem>().GetComponent<SphereCollider> ().enabled = false;
	}

	void OnTriggerEnter(Collider collider) {
		GameObject characterObject = collider.gameObject;
		PlayerCharacter characterComponent = characterObject.GetComponent<PlayerCharacter> ();
		if (characterComponent) {
			this.collidedCharacter = characterObject;
			characterObject.GetComponent<Health> ().DecreaseHealth (changeInLife);

			ArrayList playerStatusEffects = characterComponent.getCurrentStatusEffects ();
			foreach (GameObject skillStatusEffect in skillStatusEffects) {
				bool playerIsAffected = false;
				foreach (GameObject playerStatusEffect in playerStatusEffects) {
					// If the status effect is on the player
					if (skillStatusEffect.GetComponent<StatusEffect>().GetType() == playerStatusEffect.GetComponent<StatusEffect>
						().GetType()) {
						playerIsAffected = true;
						IStackable stackableStatusEffect = playerStatusEffect.GetComponent<IStackable> ();
						if (stackableStatusEffect != null) {
							stackableStatusEffect.IncreaseStack ();
						} else {
							GameObject appliedStatusEffects = Instantiate (skillStatusEffect);
							appliedStatusEffects.transform.parent = characterObject.transform;
							characterComponent.addStatusEffect (appliedStatusEffects);
						}
					}
				}
				if (playerIsAffected == false) {
					GameObject appliedStatusEffects = Instantiate (skillStatusEffect);
					appliedStatusEffects.transform.parent = characterObject.transform;
					characterComponent.addStatusEffect (appliedStatusEffects);
				}
			}


			//			Invoke ("PushBack", 0.3f);
		}
	}

	void PushBack() {
		Rigidbody rigidBody = collidedCharacter.GetComponent<Rigidbody> ();
		rigidBody.AddForce ((collidedCharacter.transform.position - transform.position) * 5000f);
	}
}
