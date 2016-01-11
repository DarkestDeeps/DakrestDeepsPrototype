using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	private Vector3 target;
	private float speed = 2;
	private float sight = 10;

	void Start() {

	}

	void Update() {

		target = FindTarget ();

		if (CanSeePlayer()) {
			Chase ();
		}
	}

	private Vector3 FindTarget() {

		return target = GameObject.Find ("Player").transform.position;
	}

	private void Chase() {

		float step = speed * Time.deltaTime;
	
		transform.LookAt(target);

		gameObject.transform.position = Vector3.MoveTowards (transform.position, target, step);

	}

	private bool CanSeePlayer() {

		if (Vector3.Distance (gameObject.transform.position, target) < sight) {
			return true;
		} else {
			return false;
		}

	}

	void OnTriggerEnter (Collider col) {

		if (col.gameObject.tag == "weapon") {
			Destroy (gameObject);
		}

	}
}
