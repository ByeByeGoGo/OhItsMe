using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

	public float speed;
	public float mouse_char_gap;

	private Rigidbody2D rgbd2d;
	private Vector2 mousePos;
	private bool facingRight = true;

	// Use this for initialization
	void Start () {
		rgbd2d = GetComponent<Rigidbody2D> ();
		mousePos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		// Mouse left
		if(Input.GetMouseButtonDown(0)) {
			mousePos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		}
	}

	void FixedUpdate() {
		float gap = mousePos.x - transform.position.x;
		Vector2 velocity = rgbd2d.velocity;
		if (Mathf.Abs (gap) > mouse_char_gap) {
			
			if (gap >= 0) {
				velocity.x = speed;
				if (!facingRight) {
					Flip ();
				}
			} else {
				velocity.x = -speed;
				if (facingRight) {
					Flip ();
				}
			}

			rgbd2d.velocity = velocity;

		} else {
			velocity.x = 0;
			rgbd2d.velocity = velocity;
		}
	}

	void Flip() {

		facingRight = !facingRight;

		Vector3 localScale = transform.localScale;
		localScale.x *= -1;
		transform.localScale = localScale;
	}
}
