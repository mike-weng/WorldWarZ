using UnityEngine;
using System.Collections;

public class HealerSingleHeal : Skill {
	private Animator animator;

	// Use this for initialization
	void Start () {
		animator = GetComponentInParent<Animator> ();

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public override void HandlePhysics() {
		print ("Skill1");
	}

	public override void UpdateAnimator () {
		print ("Update animator Skill1");
		animator.SetTrigger("Skill1");
	}
}
