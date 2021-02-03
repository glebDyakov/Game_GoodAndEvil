using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;
using UnityEditor;


public class Play : MonoBehaviour {
	public GameObject mycanvas;
	float startPosName = 310f;
	float startPosRecord = 290f;
	public GameObject playersNames;
	public InputField playerName;
	public GameObject playersRecords;
	// Use this for initialization
	void OnMouseDown () {
		
		//PlayerPrefs.SetString ("PlayersNames", PlayerPrefs.GetString ("PlayersNames") + "|" + PlayerPrefs.GetString ("CurrentPlayerName"));
		PlayerPrefs.SetString ("CurrentPlayerName", playerName.text);
		//PlayerPrefs.SetInt ("CountOfPlayers", PlayerPrefs.GetInt ("CountOfPlayers") + 1);
		SceneManager.LoadScene ("Game");

	}
	void Start(){
		//EditorPrefs.DeleteAll();
		/*
		PlayerPrefs.DeleteAll();
		PlayerPrefs.Save();
		*/
		string[] separator = { "|" }; 
		for(int counter = 0; counter < PlayerPrefs.GetString ("PlayersNames").Split(separator, StringSplitOptions.RemoveEmptyEntries).Length; counter++){
			string playerNumberName = PlayerPrefs.GetString ("PlayersNames").Split (separator, StringSplitOptions.RemoveEmptyEntries)[counter];
			GameObject name = Instantiate (playersNames, new Vector2(-401f, startPosName), Quaternion.identity, mycanvas.transform);
			name.GetComponent<TextMesh>().text += playerNumberName;
			name.transform.localPosition = new Vector2 (-401f, startPosName);
			startPosName -= 100f;
		}
		for(int counter = 0; counter < PlayerPrefs.GetString ("PlayersRecords").Split(separator, StringSplitOptions.RemoveEmptyEntries).Length; counter++){
			string playerNumberRecord = PlayerPrefs.GetString ("PlayersRecords").Split (separator, StringSplitOptions.RemoveEmptyEntries)[counter];
			GameObject record = Instantiate (playersRecords, new Vector2(-400f, startPosRecord), Quaternion.identity, mycanvas.transform);
			record.GetComponent<TextMesh>().text += playerNumberRecord;
			record.transform.localPosition = new Vector2 (-400f, startPosRecord);
			startPosRecord -= 100f;
		}
	}
}
