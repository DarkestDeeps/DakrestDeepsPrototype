using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	
	public float movementSpeed = 10;
	public float turningSpeed = 120;
	private Animator anim;
	
	void Start() {
		anim = gameObject.GetComponent<Animator>();
	}
	
	void Update() {
		
		float h = Input.GetAxisRaw ("Horizontal");
		float v = Input.GetAxisRaw ("Vertical");
		
		anim.SetInteger ("V_Dir", (int)v);
		anim.SetInteger ("H_Dir", (int)h);
		
	}
}
