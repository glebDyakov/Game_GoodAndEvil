using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Move : MonoBehaviour {
	public float speed = 5f;
	public Rigidbody2D smile;

	void Start () {


		smile = gameObject.GetComponent <Rigidbody2D>();

	}

	// Update is called once per frame
	void FixedUpdate () {
		try{
			smile.MovePosition (smile.position + new Vector2(GameManager.speedOfEvil, 0f) * Time.fixedDeltaTime);
		} catch(MissingReferenceException e){

		}
	}
}
