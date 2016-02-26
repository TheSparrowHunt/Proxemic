using UnityEngine;
using System.Collections;


public class UniversityFrontLoader : MonoBehaviour {
	public GameObject player = null;
	public Vector3 playerPositionFromTutorial = new Vector3 (-8.5f, 0.0f, -1.0f);
	public Vector3 playerPositionFromLobby = new Vector3 (0.0f, 0.0f, -1.0f);


	// Use this for initialization
	void Start () {

		//placing the player at the correct position relative to the previous room.
		if (PlayerPrefs.GetString ("PreviousRoom") == "Tutorial") {
			//instantiates the player
			player = Instantiate (Resources.Load ("Prefab/player"), playerPositionFromTutorial, Quaternion.identity) as GameObject;
		} else {
			player = Instantiate (Resources.Load ("Prefab/player"), playerPositionFromLobby, Quaternion.identity) as GameObject;
		}
		//sets the string ready for when player goes into next scene
		PlayerPrefs.SetString ("PreviousRoom", "Lobby");


	}

	// Update is called once per frame
	void Update () {

	}


	}
}
