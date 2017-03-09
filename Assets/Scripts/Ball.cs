﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	public Vector2 startingVelocity = new Vector2 (10, -20);
	private Vector3 startingPosition; 
	public GameObject gameOverSign; 
	public GameObject youWinSign; 

	int lives = 3; 

	// Use this for initialization
	void Start () {
		startingPosition = transform.position; 
		GetComponent<Rigidbody2D> ().velocity = startingVelocity; 
	}

	// Update is called once per frame
	void Update () {
		if (transform.position.y < -7.9F) {
			GetOut ();
		}
		if (Input.GetButtonDown ("Jump")) {
			GetComponent<Rigidbody2D> ().velocity = startingVelocity;
		}
	}

	void GetOut()
	{
		Debug.Log ("You are out");

		lives = lives - 1; 

		transform.position = startingPosition;
		GetComponent<Rigidbody2D> ().velocity = new Vector2 ();

		if (lives == 0) 
		{
			DoGameOver ();
		}

	}
	void DoGameOver()
	{
		gameOverSign.SetActive(true); 
	}

	public void YouBrokeABrick()
	{
		var bricksLeft = FindObjectsOfType<Brick>().Length; 
		Debug.Log ("bricksleft: "+bricksLeft);
		if (bricksLeft == 0) {
			youWinSign.SetActive (true);
		}
	}
}

