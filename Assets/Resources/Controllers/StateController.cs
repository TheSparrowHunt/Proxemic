using UnityEngine;
using System.Collections;

public class StateController : MonoBehaviour {
	public string gameState;
	public string room;
	public string interacted;
	public bool paused;

	// Use this for initialization
	void Start () {
		gameState = "Menu";
		room = "Menu";
		paused = false; 
		interacted = "";
	}
	
	// Update is called once per frame
	void Update () {
		print (gameState);
		if (gameState == "Menu") {
			//if menu music isn't already playing, play menu music
		}

		//tutorial gamestate
		if (room == "Tutorial") {
			if (gameState == "OverWorld") {
				//change music to tutorial area music
				if (paused) {
					paused = false;
				}
			} else if (gameState == "Battle") {
				//change music to hobo battle music
				if (!paused) {
					paused = true;
				}
			}
		}


	
	}

	void Awake() {
		//test if there is already an instance of this object, destroys itself if there is
		//stops us from having the music double up in the mainmenu
		GameObject[] sameTag = GameObject.FindGameObjectsWithTag("StateController");

		if (sameTag.Length > 1) {
			Destroy (this.gameObject);
		} else {

			//stops this object from getting destroyed between scenes
			DontDestroyOnLoad (this.gameObject);
		}
	}
}
