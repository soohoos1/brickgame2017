using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		var rigidBody = GetComponent<Rigidbody2D> ();
		float x = Input.GetAxisRaw ("Horizontal");
		x = x * 20;
		rigidBody.velocity = new Vector2 (x, 0);
		//transform.Translate (0.005f, 0, 0);
	}
}
