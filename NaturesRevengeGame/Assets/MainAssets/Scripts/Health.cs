using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {
	public float healthValue = 100;
	public Sprite splashTexture;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void DoDamage(float damage){
		healthValue -= damage;
		Debug.Log ("health is now: " + healthValue);
		if (healthValue <= 0) {
			GetComponent<Animator>().SetBool("Dying", true);
			GetComponent<BoxCollider> ().size = new Vector3(1, 1, 1);
			//Destroy (gameObject);
			Debug.Log("Should die");
		}
	}

	public void ShowBloodSplash(Vector3 pos){
		GameObject splash = new GameObject ();
		splash.AddComponent<SpriteRenderer> ();
		splash.AddComponent<Rigidbody> ();
		//splash.AddComponent<MeshCollider> ();
		splash.transform.position = pos;
		splash.transform.localScale = new Vector3 (0.5f, 0.5f, 0.1f);
		splash.GetComponent<SpriteRenderer> ().sprite = splashTexture;
		Destroy (splash, 1);

	}

}
