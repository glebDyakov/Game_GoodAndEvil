using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackGoodOrEvil : MonoBehaviour {
	
	public GameManager m;
	void Start(){
		//m = new GameManager ();
	}

	void OnTriggerExit2D(Collider2D other){
		if (other.tag == "isInvisible") {
			if(gameObject.name == "good" || gameObject.name == "good(Clone)"){
				--GameManager.lifes;
				//m.lifes--;
			}
			Destroy (gameObject, 1f);
		}
	}
	
	void OnMouseDown () {
		if(gameObject.name == "good" || gameObject.name == "good(Clone)"){
			++GameManager.counts;
			//m.counts++;
		} else if(gameObject.name == "evil" || gameObject.name == "evil(Clone)"){
			//m.lifes = m.lifes > 0 ? m.lifes-- : m.lifes;
			GameManager.lifes = GameManager.lifes > 0 ? --GameManager.lifes : GameManager.lifes;
		}
		/*
		//print ("GameManager.lifes " + m.lifes);
		//print ("GameManager.counts " + m.counts);
		*/
		//print ("GameManager.lifes " + GameManager.lifes);
		//print ("GameManager.counts " + GameManager.counts);
		gameObject.GetComponent<SpriteRenderer> ().enabled = false;
		//Destroy (gameObject, 1f);
		//GameManager.speedOfEvil *= 2;
	}
}
