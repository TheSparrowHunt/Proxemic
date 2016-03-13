using UnityEngine;
using System.Collections;

public class TutorialAreaLoader : MonoBehaviour {
	public GameObject player = null;
	public GameObject hobo = null;
	public Vector3 playerPositionFromMenu = new Vector3 (-7.0f, 0.0f, -1.0f);
	public Vector3 playerPositionFromUniversityFront = new Vector3 (8.5f, 0.0f, -1.0f);
	public Vector3 hoboPosition = new Vector3 (4.0f, 1.25f, -1.0f);
		

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

		//sets the statecontroller
		GameObject StateController = GameObject.Find ("StateController");
		if (StateController != null) {
			StateController.GetComponent<StateController> ().gameState = "OverWorld";
			StateController.GetComponent<StateController> ().room = "Tutorial";
		}
		//places the hobo character
		if (PlayerPrefs.GetInt ("HoboInteracted") == 0) {
			hobo = Instantiate (Resources.Load ("Prefab/hobo"), hoboPosition, Quaternion.identity) as GameObject;
		} else {
			hobo = Instantiate (Resources.Load ("Prefab/hobo 1"), hoboPosition, Quaternion.identity) as GameObject;
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
