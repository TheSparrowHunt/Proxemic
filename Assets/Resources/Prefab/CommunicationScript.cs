using UnityEngine;
using System.Collections;

public class CommunicationScript : MonoBehaviour {

	//Vector3 position;
	GameObject player;
	int sizeMod;

	// Use this for initialization
	void Start () {
		//DEBUG
		//PlayerPrefs.SetInt ("SuccessfulCounter", 5);

		if (PlayerPrefs.HasKey ("SuccessfulCounter")) {
			sizeMod = PlayerPrefs.GetInt ("SuccessfulCounter");
		} else {
			sizeMod = 0;
		}
		//transforms scale of the CommsCircle based on number of successful interactions
		transform.localScale = new Vector3 ((0.3f/10.0f) * (10.0f+(sizeMod*3)), (0.3f/10.0f) * (10.0f+(sizeMod*3)), 1);

		//the CircleCollider2D automatically resizes when the transform is changed! Heck yeah Unity!

	}
	
	// Update is called once per frame
	void Update () {

		player = GameObject.Find ("player(Clone)");
		//nullcheck then sets this location to the location of the player
		//probably should have done with tags, but I wasn't really paying attention when I coded this.
		if (GameObject.Find ("player(Clone)") != null) {
			transform.position = new Vector3(player.transform.position.x, player.transform.position.y, 0.5f);
		}
	
	}

	void OnTriggerEnter2D(Collider2D other){
		//fill this with every interaction in the game
		//and have it instantiate the object that makes the conversation/battles
		if (other.gameObject.tag == "Interactable") {
			if (other.gameObject.name == "hobo") {
				//trigger hobo conversation
				print("Interacted with hobo");
			}


		}
	}
}
