using UnityEngine;
using System.Collections;

public class FireRay : MonoBehaviour {
	public AudioSource audio;
	public AudioClip gunFire;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		

		}

	public void RayFire(float range){

			//vectors storing ray starting position and facing direction
			Vector3 rayStart;
			Vector3 rayDirection;


			rayStart = transform.position;

			rayDirection = transform.forward;
			Debug.DrawRay(rayStart, range*rayDirection);
			audio.PlayOneShot (gunFire);


			RaycastHit hit;//variable to stor info about the hit if any

			if (Physics.Raycast (rayStart, range * rayDirection, out hit)) {
			
				Debug.Log ("hit a " + hit.collider.gameObject.name);
				//hit.collider.gameObject.GetComponent<Health> ().DoDamage (50);
				//hit.collider.gameObject.GetComponent<Health> ().ShowBloodSplash (hit.point);
			if (hit.collider.tag == "Enemy"){
				hit.collider.gameObject.GetComponent<Health> ().DoDamage (50);
				hit.collider.gameObject.GetComponent<Health> ().ShowBloodSplash (hit.point);
			}


			} else {
				Debug.Log ("Miss");
			}
	}
}
