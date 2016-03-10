using UnityEngine;
using System.Collections;

public class Recoil : MonoBehaviour {
	private float currentRecoil = 0.0f;
	public float xRecoilMax = -20f;
	public float yRecoilMax = 20f;
	public float recoilTime = 5f;
	public float recoverTime = 3f;
	public float recoilStep = 0.1f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		recoiling ();
	}
	public void startRecoil(float recoilMax_x, float recoilMax_y, float recoilFireTime, float recoilRecoverTime, float recoilAmount){
		xRecoilMax = recoilMax_x;
		yRecoilMax = recoilMax_y;
		recoilTime = recoilFireTime;
		recoverTime = recoilRecoverTime;
		recoilStep = recoilAmount;
		Debug.Log ("starting recoil");

	}
	public void increaseRecoil(){
		currentRecoil += recoilStep;
	}
	public void recoiling(){
		//check for shot fired

		//check if experience recoil


		if (currentRecoil > 0f) {
			//Debug.Log ("recoil is" + currentRecoil);
			//create a rotation to store maximum recoil value
			Quaternion maxRecoil = Quaternion.Euler (xRecoilMax, yRecoilMax, 0f);
			//interpolate between current rotation and maximum rotation using delta time
			transform.localRotation = Quaternion.Slerp (gameObject.transform.localRotation, maxRecoil, Time.deltaTime * recoilTime);
			//slowly reduce current recoil by current time
			currentRecoil -= Time.deltaTime;
		} else {
			//prevent negative recoil values by setting to 0
			currentRecoil = 0f;
			//interpolate back to original value
			transform.localRotation = Quaternion.Slerp (transform.localRotation, Quaternion.identity, Time.deltaTime * recoverTime);
		}}
}
