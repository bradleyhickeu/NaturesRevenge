using UnityEngine;
using System.Collections;

public class GameControl : MonoBehaviour {
	private int Health = 100;
	private int Ammo = 10;
	private int Score = 0;
	public Vector2 pos = new Vector2 (210,10);
	public Vector2 size = new Vector2 (550,40);
	public Texture2D emptyHealth;
	public Texture2D fullHealth;



	public static GameControl control;

	// Use this for initialization
	void Start () {
		if (control == null) {
			//create a new game controller and attach script if non existent.
			DontDestroyOnLoad (gameObject);
			control = this;

		} else if (control != this) {
			//destroy if contorl exists
			Destroy (gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.H))
		{
			//make the health go down!!
			Debug.Log ("h key pressed");
			ChangeHealth (-1);

		}
		if (Input.GetKey(KeyCode.J))
		{
			//make the health go down!!
			Debug.Log ("j key pressed");
			ChangeHealth (1);

		}
		if (Input.GetKeyDown(KeyCode.A))
		{
			//make the health go down!!
			Debug.Log ("a key pressed");
			ChangeAmmo (-1);

		}
		if (Input.GetKeyDown(KeyCode.S))
		{
			//make the health go down!!
			Debug.Log ("s key pressed");
			ChangeScore (1);

		}
	}

	void OnGUI()
	{
		GUI.Label (new Rect (10, 10, 100, 50), "Health:" + Health);
		GUI.Label (new Rect (10, 20, 100, 50), "Ammo:" + Ammo);
		GUI.Label (new Rect (10, 30, 100, 50), "Score:" + Score);

		GUI.BeginGroup(new Rect(pos.x,pos.y,size.x,size.y));
		GUI.DrawTexture (new Rect (0, 0, size.x, size.y), emptyHealth);

		GUI.BeginGroup(new Rect(0,0,size.x*Health/100,size.y));
		GUI.DrawTexture (new Rect (0, 0, size.x, size.y), fullHealth);


		GUI.EndGroup ();
		GUI.EndGroup ();


	}






	public void ChangeHealth(int damage){
		Health += damage;
		if (Health < 0) {
			Health = 0;		
		}
		if (Health > 100) {
			Health = 100;		
		}
	}

	public void ChangeAmmo(int difference){
		Ammo += difference;
		if (Ammo < 0) {
			Ammo = 0;		
		}
		if (Ammo > 10) {
			Ammo = 10;		
		}
	}

	public void ChangeScore(int amount){
		Score += amount;
		if (Score < 0) {
			Score = 0;		
		}

	}
}
