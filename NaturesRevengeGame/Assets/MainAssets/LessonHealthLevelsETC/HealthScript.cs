using UnityEngine;
using System.Collections;

public class HealthScript: MonoBehaviour {

	public int HealthRemaining;

	// Use this for initialization
	public void ChangeHealth(int difference)
	{
		HealthRemaining -= difference;
		if (HealthRemaining < 0) {
			HealthRemaining = 0;		
		}
		if (HealthRemaining > 100) {
			HealthRemaining = 100;		
		}



	}
	
	void OnGUI()
	{
		GUI.Label (new Rect (10, 10, 100, 50), "Health:" + HealthRemaining);
	}
}
