using UnityEngine;
using System.Collections;

public class MuzzleFlash : MonoBehaviour {
	public ParticleSystem flashParticle;
	public Light muzzleFlashLight;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{

	}
		
	
			

			
		

	public void muzzleFlashPlay(){
		flashParticle.Play ();
		flashParticle.Emit (15);
		muzzleFlashLight.enabled = flashParticle.isPlaying;
	}
	}

