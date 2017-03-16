using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	

	void OnCollisionEnter2D(Collision2D coll)
	{
		gameObject.SetActive (false);	
	}
}
