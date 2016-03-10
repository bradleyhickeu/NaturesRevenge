using UnityEngine;
using System.Collections;

public class keypress : MonoBehaviour {
	public GameObject HealthBar;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	if (Input.GetKeyDown(KeyCode.H))
		{
			//make the health go down!!
			Debug.Log ("h key pressed");
			GameObject.FindWithTag ("HealthBar").GetComponent<HealthScript> ().ChangeHealth(10);
		}
	

	if (Input.GetKeyDown(KeyCode.I))
	{
		//make the health go down!!
		Debug.Log ("I key pressed");
		HealthBar.GetComponent<HealthScript> ().ChangeHealth(-10);
	}
}
}
