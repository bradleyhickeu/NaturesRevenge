using UnityEngine;
using System.Collections;

public class DespawnEnemy : StateMachineBehaviour {

	override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		Destroy (animator.gameObject, 5);
		Debug.Log ("DESTROYED!");
	}
}
