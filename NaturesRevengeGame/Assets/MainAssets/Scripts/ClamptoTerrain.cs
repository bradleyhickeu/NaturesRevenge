using UnityEngine;
using System.Collections;

public class ClamptoTerrain : MonoBehaviour {
	//public GameObject attached;
	// Use this for initialization
	//public float yOffSet = 15.0f;
	private Vector3 temp;
	private Vector3 tempscale;
	void Start () {
		//Debug.Log(Terrain.activeTerrain.SampleHeight(transform.position));

		Vector3 temp = transform.position;
		Vector3 tempscale = transform.localScale;


		temp.y = Terrain.activeTerrain.SampleHeight (transform.position)+ (tempscale.y/2);
		Debug.Log (tempscale.y);
		//transform.position = temp;
		transform.position = temp;

			
	}
	
	// Update is called once per frame
	void Update () {



	}
}
