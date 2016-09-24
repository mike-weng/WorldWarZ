using UnityEngine;
using System.Collections;

public abstract class StatusEffect : MonoBehaviour {

	internal float damagePerSecond;
	internal float duration;
	internal uint stacks;

	public virtual void Start () {
		stacks = 1;
	}



}
