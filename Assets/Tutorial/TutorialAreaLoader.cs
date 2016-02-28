using UnityEngine;
using System.Collections;

public class TutorialAreaLoader : MonoBehaviour {
	public GameObject player = null;
	public Vector3 playerPositionFromMenu = new Vector3 (-7.0f, 0.0f, -1.0f);
	public Vector3 playerPositionFromUniversityFront = new Vector3 (8.5f, 0.0f, -1.0f);


	// Use this for initialization
	void Start () {



		//placing the player at the correct position relative to the previous room.
		if (PlayerPrefs.GetString ("PreviousRoom") == "UniversityFront") {
			//instantiates the player
			player = Instantiate (Resources.Load ("Prefab/player"), playerPositionFromUniversityFront, Quaternion.identity) as GameObject;
		} else {
			player = Instantiate (Resources.Load ("Prefab/player"), playerPositionFromMenu, Quaternion.identity) as GameObject;
		}
		//sets the string ready for when player goes into next scene
		PlayerPrefs.SetString ("PreviousRoom", "Tutorial");

		GameObject StateController = GameObject.Find ("StateController");

		StateController.GetComponent<StateController>().gameState = "OverWorld";
		StateController.GetComponent<StateController>().room = "Tutorial";

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
