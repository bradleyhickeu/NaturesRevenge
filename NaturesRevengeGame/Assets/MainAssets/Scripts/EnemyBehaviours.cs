using UnityEngine;
using System.Collections;

public class EnemyBehaviours : MonoBehaviour {
	bool isDead;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		isDead = GetComponent<Animator> ().GetBool ("Dead");


	if(isDead == true){
			transform.Translate (Vector3.up * 90, Space.World);
	}
}
}
