using UnityEngine;
using System.Collections;

public class FaceCamera : MonoBehaviour {

	private GameObject cam;

	// Use this for initialization
	void Start () {
		cam = GameObject.FindWithTag ("MainCamera");
	}
	
	// Update is called once per frame
	void Update () {
		//transform.LookAt (cam.transform);
		Vector3 vecToCam = cam.transform.position - transform.position;
		vecToCam.y =0;
		vecToCam.Normalize();
		
		this.transform.forward = vecToCam;
	}
}
