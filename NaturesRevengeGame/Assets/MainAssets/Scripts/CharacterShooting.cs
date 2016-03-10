using UnityEngine;
using System.Collections;

public class CharacterShooting : MonoBehaviour {
	//aim down sights script
	public GameObject gun;
	//camera field of view floats
	float  nextPos = 0.0f;
	float  nextField = 40.0f;
	float nextPos2 = -0.2f;

	float timeSmooth = 0.2f;

	float Velocity = 0.4f;
	float Velocity2 = 0.4f;
	float Velocity3 = 0.4f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		float newPos = Mathf.SmoothDamp(gun.transform.localPosition.x,  nextPos, ref Velocity, timeSmooth);
		float newField = Mathf.SmoothDamp(Camera.main.fieldOfView,  nextField,ref  Velocity2, timeSmooth);
		float newPos2 = Mathf.SmoothDamp(gun.transform.localPosition.y,nextPos2,ref Velocity3,timeSmooth);

		Vector3 temp = gun.transform.localPosition;
		temp.x = newPos;
		temp.y = newPos2;
		gun.transform.localPosition = temp;
		//gun.transform.localPosition.x = newPos;
		//gun.transform.localPosition.y = newPos2;
		Camera.main.fieldOfView = newField;

		if (Input.GetMouseButton(1)) {
			//adjust viewpoint and gun position
			nextField = 40.0f;
			nextPos = 0.0f;
			nextPos2 = -0.2f;

	
		} else {
			//adjust viewpoint and gun position
			nextField = 60.0f;
			nextPos = 0.5f;
			nextPos2 = -0.4f;


		}
	}
	}




