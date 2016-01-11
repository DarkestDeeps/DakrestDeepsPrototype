using UnityEngine;
using System.Collections;

public class Swing : MonoBehaviour {

	private Animator swingArm;

	// Use this for initialization
	void Start () {	
		swingArm = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			int choice = Random.Range(0,2);
			if (choice == 0) {
				swingArm.Play ("Swing");
			}
			else {
				swingArm.Play ("Slash");
			}
			swingArm.StopPlayback();
		}
	}
}
