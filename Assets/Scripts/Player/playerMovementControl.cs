﻿using UnityEngine;
using System.Collections;

public class playerMovementControl : MonoBehaviour {

	public float maxSpeed = 2.0F;

	void Start (){
	}

	void FixedUpdate() {

		float move = Input.GetAxis ("Horizontal");
		rigidbody2D.velocity = new Vector2(move * maxSpeed, rigidbody2D.velocity.y);

	}



}