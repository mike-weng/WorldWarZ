using UnityEngine;
using System.Collections;

public class HealerMultiHeal : Skill {
	private Animator animator;

	// Use this for initialization
	void Start () {
		animator = GetComponentInParent<Animator> ();

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public override void HandlePhysics() {
		print ("Skill2");
	}

	public override void UpdateAnimator () {
		print ("Update animator Skill2");
		animator.SetTrigger("Skill2");
	}
}
