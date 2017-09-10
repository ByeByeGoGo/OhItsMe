using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Droplet : MonoBehaviour {

	public ParticleSystem SprayParticle;

	void OnCollisionEnter2D (Collision2D col) {
		if (col.gameObject.tag == "Ground") {

			ParticleSystem ps = Instantiate (SprayParticle, transform.position, transform.rotation) as ParticleSystem;
			ps.Play ();


			Destroy (gameObject);
		}
	}
}
