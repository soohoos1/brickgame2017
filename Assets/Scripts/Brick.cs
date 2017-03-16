using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

	public int health = 2; 
	public int points = 1; 

	// Use this for initialization
	void Start () {
		
	}
	
	void OnCollisionEnter2D(Collision2D coll)
	{
		health -= 1; //health -= 1 is the same as health = health -1, it is just saying subtracting one in this case

		//GetComponent<SpriteRenderer> ().color = new Color (2, 2, 2, health * 0.2F); //red, green, blue

		if(health==0) {
			gameObject.SetActive (false);
			FindObjectOfType<Ball> ().YouBrokeABrick(points); //worth = points
		}

	}




}
