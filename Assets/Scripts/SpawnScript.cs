using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {
	public GameObject[] obj;
	public Transform loca;
	public int diff;
	public float spawnMin = 1f;
 	public float spawnMax = 2f;

	// Use this for initialization
	void Start () {
		Spawn ();
	}

	void Spawn () {

		Instantiate (obj [Random.Range (0, obj.GetLength (0))], new Vector3 (loca.position.x , loca.position.y + diff, 0), Quaternion.identity);
		Invoke ("Spawn", Random.Range(spawnMin, spawnMax)); 

	}

}