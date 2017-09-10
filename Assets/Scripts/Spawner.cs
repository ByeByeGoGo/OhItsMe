using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public float timeDelay;
	public float timeSpwan;
	public GameObject droplet;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("Spwan", timeDelay, timeSpwan);
	}

	void Spwan() {
		Instantiate (droplet, transform.position, transform.rotation);
	}
}
