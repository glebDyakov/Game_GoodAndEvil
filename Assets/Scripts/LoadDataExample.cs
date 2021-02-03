using System.Collections;
//using Firebase.Database;
//using Firebase;
using System.Collections.Generic;
using UnityEngine;
//using Newtonsoft.Json;

public class LoadDataExample : MonoBehaviour {

	void Awake () {
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
		*/
		//DatabaseReference reference = FirebaseDatabase.DefaultInstance.RootReference;
		//_database = FirebaseDatabase.GetInstance("/players");
		//_database.GetReference("players").SetRawJsonValueAsync(JsonUtility.ToJson("players"));
		//asdasdadasdasdasdssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssss
		/*
		var reference = FirebaseDatabase.DefaultInstance.GetReference ("players");
		reference.GetValueAsync ().ContinueWith (task => ParseNews (task.Result));
		*/
}	/*
	void ParseNews(DataSnapshot snapshot){
		var json = snapshot.GetRawJsonValue();
		var newsList = JsonConvert.DeserializeObject<Dictionary<string, News>> (json);
		Debug.Log("News Count: " + newsList.Count.ToString());
		foreach (var newItem in newsList){
			Debug.Log("title: " + newsItem.Value.title.ToString() + ", message: " + newsItem.Value.message.ToString());
		}
	}
	*/
}
