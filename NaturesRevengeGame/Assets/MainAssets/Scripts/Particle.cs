using UnityEngine;
using System.Collections;

public class Particle : MonoBehaviour {

	public Color colorStart = new Color(1,1,1,1);
	public Color colorEnd= new Color(1,1,1,0);
	public float lifeTime = 0.5f;
	private float timeAlive;


	// Use this for initialization
	void Start () {
		float size = transform.localScale.y; 
		GetComponent<Rigidbody> ().drag = size/6;
		timeAlive = 0.0f;

	}



	// Update is called once per frame
	void Update () {
		
		timeAlive += Time.deltaTime;

		if (timeAlive >= lifeTime) {
			Destroy (this.gameObject);
			ParticleSys.numParticles--;
			//Debug.Log(ParticleSys.numParticles);



		}

		float propOfLife = timeAlive / lifeTime;
		Color colorNow = Color.Lerp (colorStart, colorEnd, propOfLife);
		GetComponent<SpriteRenderer> ().material.color = colorNow;

	}


}
