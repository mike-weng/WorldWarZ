using UnityEngine;
using System.Collections;

public abstract class Skill : MonoBehaviour {
	
	internal Animator animator;
	internal ParticleSystem skillParticleSystem;
	internal SphereCollider skillCollider;
	internal GameObject collidedCharacter;
	internal float changeInLife;
	public GameObject[] skillStatusEffects;
	public abstract void HandlePhysics ();
	public abstract void UpdateAnimator ();

	public virtual void Start () {
		animator = GetComponentInParent<Animator> ();
		skillParticleSystem = GetComponent<ParticleSystem> ();
		skillCollider = GetComponent<SphereCollider> ();
	}
}
