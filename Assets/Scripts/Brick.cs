using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

	public GameObject brickLevel2;

	// Use this for initialization
	void Start () {
		
	}
	
	void OnCollisionEnter2D(Collision2D coll)
	{
		gameObject.SetActive (false);

			DoBrickLevel2 ();

	}


	void DoBrickLevel2 ()
	{
		brickLevel2.SetActive(true);
	}
}
