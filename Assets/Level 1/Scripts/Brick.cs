using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

	public int health = 2; 

	// Use this for initialization
	void Start () {
		
	}
	
	void OnCollisionEnter2D(Collision2D coll)
	{
		health -= 1; //health -= 1 is the same as health = health -1, it is just saying subtracting one in this case

		if(health==0) {
			gameObject.SetActive (false);
			FindObjectOfType<Ball> ().YouBrokeABrick();
		}

	}




}
