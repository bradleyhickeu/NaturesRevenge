using UnityEngine;
using System.Collections;
 
public class SpawnEnemies : MonoBehaviour {
	public GameObject Enemy;
	// Use this for initialization
	void Start () {
		
		for (int i = 0; i < 30; i++) {
			float x = Random.Range (-250, 250);
			float z = Random.Range (-250, 250);
			Instantiate(Enemy,new Vector3(x,0,z),Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
