using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	
	public float movementSpeed = 10;
	public float turningSpeed = 120;
	private Animator anim;
	private Rigidbody rigibody;
	
	void Start() {
		anim = gameObject.GetComponent<Animator>();
		rigibody = gameObject.GetComponent<Rigidbody>();
	}
	
	void Update() {
		
		float h = Input.GetAxisRaw ("Horizontal");
		float v = Input.GetAxisRaw ("Vertical");
		bool jump = Input.GetKeyDown ("space");
		
		transform.Rotate(0, h * turningSpeed * Time.deltaTime, 0);
		
		anim.SetInteger ("Direction", (int)v);
		anim.SetBool ("Jump", jump);
		anim.SetBool ("Grounded", isGrounded ());
		
	}

	bool isGrounded() {
		if (rigibody.velocity.y == 0) {
			return true;
		} else {
			return false;
		}
	}
}
