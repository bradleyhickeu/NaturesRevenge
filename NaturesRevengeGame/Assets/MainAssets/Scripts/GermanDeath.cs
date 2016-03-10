using UnityEngine;
using System.Collections;

public class GermanDeath : StateMachineBehaviour {
	
	override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		animator.SetBool("Dead", true);
		Debug.Log ("dead!");
	}
}
