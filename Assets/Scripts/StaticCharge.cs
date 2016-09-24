using UnityEngine;
using System.Collections;

public class StaticCharge : StatusEffect, IStackable {
	private float timeSinceLastTrigger = 0f;
	private uint MAX_STACKS = 5;
	// Use this for initialization
	public override void Start () {
		base.Start ();
	}
	
	// Update is called once per frame
	void Update () {
		timeSinceLastTrigger += Time.deltaTime;
		print (timeSinceLastTrigger);
		if (timeSinceLastTrigger > 1.0f) {
			DecreaseStack ();
		}
	}

	public void IncreaseStack() {
		timeSinceLastTrigger = 0f;
		base.stacks += 1;
		print (base.stacks);
		if (IsMaxStacks()) {
			print ("stun");
			base.stacks = 0;
		}
	}
	public void DecreaseStack() {
		timeSinceLastTrigger = 0f;
		if (base.stacks > 0) {
			base.stacks -= 1;
		}
		if (base.stacks == 0) {
			print ("destroy");
			DestroyObject (this.gameObject);
		}
	}

	public bool IsMaxStacks() {
		if (base.stacks == MAX_STACKS) {
			return true;
		} else {
			return false;
		}
	}



}
