using UnityEngine;
using System.Collections;

public abstract class Skill : MonoBehaviour {
	
	internal Animator animator;
	internal SphereCollider skillCollider;
	internal GameObject collidedCharacter;
	internal float changeInLife;
    public bool isExecuting = false;

    public abstract void HandlePhysics ();
	public abstract void UpdateAnimator ();

	public virtual void Start () {
		animator = GetComponentInParent<Animator> ();
		skillCollider = GetComponent<SphereCollider> ();
	}
}
