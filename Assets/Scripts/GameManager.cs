using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
/*
using Firebase;
using Firebase.Database;
using System.Threading.Tasks;

*/
[RequireComponent(typeof(AttackGoodOrEvil))]
public class GameManager : MonoBehaviour {
	//public FirebaseDatabase _database;
	//public string characterName;
	//GameObject character;
	//public List<GameObject> characters;
	public static float speedOfGood = 5f;
	public static float speedOfEvil = 5f;
	public GameObject good;
	public GameObject evil;
	public static float speedOfInst = 5f;
	/*
	public int lifes = 5;
	public int counts = 0;
	*/
	public static int lifes = 5;
	public static int counts = 0;

	/*
	public GameObject good;
	public GameObject evil;
	public float speed = 5f;
	public Rigidbody2D goodrb;
	public Rigidbody2D evilrb;

	void Start () {
		
		goodrb = good.GetComponent <Rigidbody2D>();
		evilrb = evil.GetComponent <Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		try{
			goodrb.MovePosition (goodrb.position + new Vector2(5f, 0f) * Time.fixedDeltaTime);
			evilrb.MovePosition (evilrb.position +  new Vector2(5f, 0f) * Time.fixedDeltaTime);
			//good.GetComponent<Rigidbody2D> ().MovePosition(goodrb);
		} catch(MissingReferenceException e){
			
		}
	}
	*/
	void Start(){
		/*
		FirebaseApp.CheckAndFixDependenciesAsync ().ContinueWith (task => {
			if(task.Exception != null){
				Debug.LogError($"{task.Exception}");
				return ;
			}
			
		});
		*/

		/*
		Firebase.FirebaseApp.CheckAndFixDependenciesAsync().ContinueWith(task => {
		  var dependencyStatus = task.Result;
		  if (dependencyStatus == Firebase.DependencyStatus.Available) {
		    // Create and hold a reference to your FirebaseApp,
		    // where app is a Firebase.FirebaseApp property of your application class.
			FirebaseApp app = Firebase.FirebaseApp.DefaultInstance;
			print("abc");
			//FirebaseDatabase.GetInstance(app, "https://console.firebase.google.com/u/0/project/goodandevil-abaa7/database/goodandevil-abaa7-default-rtdb/data");
			//print(reference.Push().ToString());
			//FirebaseDatabase.GetInstance("/players");
			
		    // Set a flag here to indicate whether Firebase is ready to use by your app.
		  } else {
		    UnityEngine.Debug.LogError(System.String.Format(
		      "Could not resolve all Firebase dependencies: {0}", dependencyStatus));
		    // Firebase Unity SDK is not safe to use here.
		  }
		});
		//DatabaseReference reference = FirebaseDatabase.DefaultInstance.RootReference;
		_database = FirebaseDatabase.GetInstance("/players");
		_database.GetReference("players").SetRawJsonValueAsync(JsonUtility.ToJson("players"));
		*/
		//print (reference.ToString());
		//print(reference.Child("/players").ToString());


		lifes = 5;
		counts = 0;
		StartCoroutine (AddSmile());
	}
	/*
	public async Task<bool> SaveExists(){
		DataSnapshot dataSnapshot = await _database.GetReference("players").GetValueAsync();
		return dataSnapshot.Exists;
	}
	*/
	IEnumerator AddSmile(){
		//while(GameManager.m >= )){
		while(GameManager.lifes >= 0){
			//GameObject character = characters[Random.Range(0, characters.Count)];
			//if(characterName == "good"){	
			Instantiate (evil, evil.transform.position, Quaternion.identity);
			Instantiate (good, good.transform.position, Quaternion.identity);
			//} else if(characterName == "evil"){	
			//	Instantiate (character, character.transform.position, Quaternion.identity);
			//}
			GameManager.speedOfInst = GameManager.speedOfInst >= 1.1f ? GameManager.speedOfInst - 0.1f : GameManager.speedOfInst;
			yield return new WaitForSeconds(GameManager.speedOfInst);

		}

		if (PlayerPrefs.GetString ("PlayersNames").Contains (PlayerPrefs.GetString ("CurrentPlayerName"))) {
			string[] separator = { "|" }; 
			int playerNumber = 0;
			for(int counter = 0; counter < PlayerPrefs.GetString ("PlayersNames").Split(separator, StringSplitOptions.RemoveEmptyEntries).Length; counter++){
				string playerNumberName = PlayerPrefs.GetString ("PlayersNames").Split (separator, StringSplitOptions.RemoveEmptyEntries)[counter];
				if (playerNumberName.Contains (PlayerPrefs.GetString ("CurrentPlayerName")) && PlayerPrefs.GetString ("CurrentPlayerName") == playerNumberName) {
					playerNumber = counter;
					string playerNumberRecord = PlayerPrefs.GetString ("PlayersRecords").Split (separator, StringSplitOptions.RemoveEmptyEntries)[playerNumber];
					for(int anotherCounter = 0; anotherCounter < PlayerPrefs.GetString ("PlayersRecords").Split(separator, StringSplitOptions.RemoveEmptyEntries).Length; anotherCounter++){
						if (playerNumber == anotherCounter ) {
							PlayerPrefs.SetString ("PlayersRecords", PlayerPrefs.GetString ("PlayersRecords").Replace (PlayerPrefs.GetString ("PlayersRecords").Split (separator, StringSplitOptions.RemoveEmptyEntries) [playerNumber], GameManager.counts.ToString()));
						}
					}
					break;
				}
			}
			/*
			for(int counter = 0; counter < PlayerPrefs.GetString ("PlayersRecords").Split(separator, StringSplitOptions.RemoveEmptyEntries).Length; counter++){
				if (playerNumber == counter) {
					PlayerPrefs.SetString ("PlayersRecords", PlayerPrefs.GetString ("PlayersRecords").Replace (PlayerPrefs.GetString ("PlayersRecords").Split (separator, StringSplitOptions.RemoveEmptyEntries) [playerNumber], GameManager.counts.ToString()));
				}
			}
			*/

		} else {

			PlayerPrefs.SetString ("PlayersNames", PlayerPrefs.GetString ("PlayersNames") + "|" + PlayerPrefs.GetString ("CurrentPlayerName"));
			PlayerPrefs.SetString ("PlayersRecords", PlayerPrefs.GetString ("PlayersRecords") + "|" + GameManager.counts);
		}
		SceneManager.LoadScene ("Menu");
	}
	public static void AddLife(){
		++GameManager.lifes;
	}
	public static void MinusLife(){
		--GameManager.lifes;
	}
	public static void AddCounts(){
		GameManager.counts += 1;
	}
}
