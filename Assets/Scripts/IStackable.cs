using UnityEngine;
using System.Collections;

public interface IStackable {
	void IncreaseStack();
	void DecreaseStack();
	bool IsMaxStacks();
}
