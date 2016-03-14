using UnityEngine;
using System.Collections;

public class StateController : MonoBehaviour {
	public string gameState;
	public string room;
	public string interacted;
	public bool paused;

	public AudioSource[] music;
	public AudioSource outOfBattle;
	public AudioSource inBattle;

	// Use this for initialization
	void Start () {
		music = GetComponents<AudioSource> ();

		outOfBattle = music [0];
		inBattle = music [1]; 

		gameState = "Menu";
		room = "Menu";
		paused = false; 
		interacted = "";
	}
	
	// Update is called once per frame
	void Update () {
		//DEBUG
		//print (gameState);
		if (gameState == "Menu") {
			//if menu music isn't already playing, play menu music
		}

		//tutorial gamestate
		if (room == "Tutorial") {
			if (gameState == "OverWorld") {
				if (!outOfBattle.isPlaying) {
					outOfBattle.Play ();
				}
				if (inBattle.isPlaying) {
					inBattle.Stop ();
				}
				if (paused) {
					paused = false;
				}
			} else if (gameState == "Battle") {
				if (!inBattle.isPlaying) {
					inBattle.Play ();
				}
				if (outOfBattle.isPlaying) {
					outOfBattle.Stop ();
				}
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
