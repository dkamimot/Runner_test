using UnityEngine;
using System.Collections;

public class PowerUpScript : MonoBehaviour {

	HUDScript hud;
	// Use this for initialization
	void Start () {
	
	}
	void OnTriggerEnter2D(Collider2D other){
	
		if (other.tag == "Player") {
			hud = GameObject.Find("Main Camera").GetComponent<HUDScript>();
			hud.increaseScore(10);
			Destroy (this.gameObject);
		}
	
	}
	// Update is called once per frame
	void Update () {
	
	}
}
