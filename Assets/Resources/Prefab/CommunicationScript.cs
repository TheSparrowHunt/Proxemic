using UnityEngine;
using System.Collections;

public class CommunicationScript : MonoBehaviour {

	//Vector3 position;
	GameObject player;
	int sizeMod;
	GameObject makeBattle;

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
			transform.position = new Vector3(player.transform.position.x, player.transform.position.y-0.35f, 0.5f);
		}
	
	}

	void OnTriggerEnter2D(Collider2D other){
		
		//fill this with every interaction in the game
		//and have it instantiate the object that makes the conversation/battles
		if (other.gameObject.tag == "Interactable") {
			if (other.gameObject.name == "hobo(Clone)") {
				GameObject StateController = GameObject.Find ("StateController");
				StateController.GetComponent<StateController>().interacted = "hobo";


				//print("Interacted with hobo");

				makeBattle = Instantiate (Resources.Load ("Prefab/MakeBattle"), new Vector3(0.0f,0.0f,-1.0f), Quaternion.identity) as GameObject;
			}
			if (other.gameObject.name == "metal(Clone)") {
				GameObject StateController = GameObject.Find ("StateController");
				StateController.GetComponent<StateController>().interacted = "metal";


				//print("Interacted with hobo");

				makeBattle = Instantiate (Resources.Load ("Prefab/metal/makeBattleMetal"), new Vector3(0.0f,0.0f,-1.0f), Quaternion.identity) as GameObject;
			}

			if (other.gameObject.name == "IDPerson(Clone)") {
				GameObject StateController = GameObject.Find ("StateController");
				StateController.GetComponent<StateController>().interacted = "IDPerson";


				print("Interacted with IDPerson");

				makeBattle = Instantiate (Resources.Load ("Prefab/IDCard/makeBattleID"), new Vector3(0.0f,0.0f,-1.0f), Quaternion.identity) as GameObject;
			}


		}
	}
}
