using UnityEngine;
using System.Collections;

public class playerAnimationControl : MonoBehaviour {

	public bool facingRight = true;
	public bool running = false;
	private Animator animator;

	// Use this for initialization
	void Start () {
	
		animator = GetComponent<Animator>();

	}
	
	// Update is called once per frame
	void Update () {

		float h = Input.GetAxis("Horizontal");
	
		if (Mathf.Abs(h) > 0.1)
			running = true;
		else 
			running = false;

				if(h > 0 && !facingRight)
					Flip ();
				else if(h < 0 && facingRight)
					Flip ();
	
		animator.SetBool("Running", running);
	}

	void Flip(){
		
		facingRight = !facingRight;
		Vector3 theRotation = transform.localEulerAngles;
		theRotation.y *= -1;
		transform.localEulerAngles = theRotation;
		
	}
}
