using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backend : MonoBehaviour {
	string url="http://localhost:6006";
	string url2 = "https://klike.net/uploads/posts/2019-06/1560329641_2.jpg"; 
		/*
	WWW www;
	// Use this for initialization
	void Start () {
		 www = new WWW (url);
		func ();
		print (www);
	}
	WWW func(){
		return www;
	}
	
	// Update is called once per frame
	void Update () {
		
	}*/
	IEnumerator Start()
	{
		using (WWW www = new WWW(url))
		{
			yield return www;
			/*Renderer renderer = GetComponent<Renderer>();
			renderer.material.mainTexture = www.texture;*/
		}
	}
}
