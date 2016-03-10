using UnityEngine;
using System.Collections;

public class ParticleSys : MonoBehaviour {

	public static int numParticles = 0;
	public float particleMaxSize = 1;
	public float particleMinSize = 1;
	private float particleTrueSize;

	public int MaxForceX;
	public int MinForceX;

	public int MaxForceY;
	public int MinForceY;

	public int MaxForceZ;
	public int MinForceZ;
	public float duration = 1.0f;

	private bool bEmitting = false;
	private float timeElapsed;
	public GameObject particleMaster;

	// Use this for initialization
	void Start () {
		timeElapsed = 0.0f;
		bEmitting = true;
	}

	void Update()
	{
		particleTrueSize = Random.Range (particleMaxSize, particleMinSize);
		timeElapsed += Time.deltaTime;
		if (timeElapsed >= duration) {
			bEmitting = false;
		}
		if (bEmitting){
			CreateParticle (Vector3.zero, transform.forward);
		}
		if (bEmitting == false && numParticles == 0) {
			Destroy (this.gameObject);
			Debug.Log (" particle system destroyed");
		}

	}


	// Update is called once per frame
	void CreateParticle(Vector3 pos_, Vector3 velocity_)
	{
		
		GameObject particle = Instantiate (particleMaster, transform.position, Quaternion.identity) as GameObject;
		//make it a child of current game object
		particle.transform.parent = gameObject.transform;
		numParticles++;

		particle.GetComponent<Rigidbody> ().AddForce( new Vector3(Random.Range(MinForceX,MaxForceX)*1f,Random.Range(MinForceY,MaxForceY)*1f,Random.Range(MinForceZ,MaxForceZ)*1f ),ForceMode.VelocityChange);
		particle.transform.localScale = new Vector3 (particleTrueSize, particleTrueSize, 1);
	}

}
