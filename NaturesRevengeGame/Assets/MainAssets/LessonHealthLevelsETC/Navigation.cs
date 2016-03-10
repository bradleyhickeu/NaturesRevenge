using UnityEngine;
using System.Collections;

public class Navigation : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void GoToLevel1(){
		Application.LoadLevel ("level1");
	}
	public void GoToMenu(){
		Application.LoadLevel ("menu");
	}
	public void GoToLevel2(){
		Application.LoadLevel ("level2");
	}
	public void GoToCredits(){
		Application.LoadLevel ("credits");
	}
}
