using UnityEngine;
using System.Collections;

public class ParticleSystemAutoDestruct : MonoBehaviour {
	private ParticleSystem partSystem;
	// Use this for initialization
	void Start () {
		partSystem = GetComponent<ParticleSystem> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (partSystem)
		{
			if (!partSystem.IsAlive ()) {
				Destroy (gameObject);
			}
	}
}
}