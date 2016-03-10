using UnityEngine;
using System.Collections;


public class GunScript : MonoBehaviour {
	public float gunRange =50f;
	public float maxRecoilX = -20f;
	public float maxRecoilY = 20f;
	public float recoilSpeed = 5f;
	public float recoverSpeed = 3f;
	public float recoilAmount = 0.1f;
	public float rateOfFire = 10f;

	public GameObject Recoiller;

	private bool b_AllowFire = true;
	// Use this for initialization
	void Start () {
		Recoiller.GetComponent<Recoil> ().startRecoil (maxRecoilX, maxRecoilY, recoilSpeed, recoverSpeed, recoilAmount);
	}
	
	// Update is called once per frame
	void Update () {
		//calls check weapon fire continually, but allow enumerator access
		StartCoroutine (CheckWeaponFire ());

			
	}
	//A function that waits a period of time before allowing firing again using R-o-f param
	IEnumerator CheckWeaponFire(){

		if (Input.GetMouseButton (0) && b_AllowFire == true) {
			
			//Debug.Log ("fireweapon function");
			b_AllowFire = false;
			FireWeapon ();
			//Debug.Log ("fired");
			//pauses the function for rateOfFire seconds before continuing
			yield return new WaitForSeconds (rateOfFire);
			b_AllowFire = true;
			Debug.Log ("firing allowed");


		}
}

	void FireWeapon(){
		
		Debug.Log ("beginning");


		Recoiller.GetComponent<Recoil> ().increaseRecoil ();
		Debug.Log ("end of recoil");
		GetComponentInParent<FireRay> ().RayFire (gunRange);
		Debug.Log ("function end");
		GetComponent<MuzzleFlash> ().muzzleFlashPlay ();

		}
}
