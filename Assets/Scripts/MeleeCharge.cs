using UnityEngine;
using System.Collections;

public class MeleeCharge : Skill {
	private Animator animator;

	// Use this for initialization
	void Start () {
		animator = GetComponentInParent<Animator> ();

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public override void HandlePhysics() {
		print ("Charge");
	}

	public override void UpdateAnimator () {
		print ("Update animator attack");
		animator.SetTrigger("Skill2");
	}
}
